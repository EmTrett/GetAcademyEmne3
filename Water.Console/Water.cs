namespace Water.Console;

public class Water
{
    public double VolumeOfFirstState;
    public WaterState State { get; set; }
    public double Temperature { get; private set; }
    public double Amount { get; }
    public Water(double waterAmount, double waterTemperature, double? volumeOfState = null)
    {
        
        Amount = waterAmount;
        Temperature = waterTemperature;
        State = Temperature < +0 ? WaterState.Ice :
            Temperature > 100 ? WaterState.Gas :
            WaterState.Fluid;
        if(waterTemperature is not (0 or 100))return;

        if (volumeOfState == null)
            throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        
        VolumeOfFirstState = volumeOfState.Value;

        if (volumeOfState == 1) return;
        if (volumeOfState == 0) State = Temperature == 0 ? WaterState.Fluid : WaterState.Gas;
        else State = Temperature == 0 ? WaterState.IceAndFluid : WaterState.FluidAndGas;
    }

    public void AddEnergy(double energyAmount)
    {
        if (Temperature < 0) energyAmount = HeatTo(energyAmount, 0);
        if (Temperature == 0 && State != WaterState.Fluid) energyAmount = DoStateChangeAsMuchAsPossible(energyAmount);
        if (Temperature < 100) energyAmount = HeatTo(energyAmount, 100);
        if (Temperature == 100 && State != WaterState.Gas) energyAmount = DoStateChangeAsMuchAsPossible(energyAmount);
        HeatMax(energyAmount);
    }

    private double DoStateChangeAsMuchAsPossible(double energyAmount)
    {
        if (energyAmount <= 0) return 0;
        if (Temperature != 0 && Temperature != 100) throw new ApplicationException("Cannot do state change when temperature is not 0 or 100.");

        var isIce = Temperature == 0;
        var stateChangeEnergyPerGram = isIce ? 80 : 600;
        var caloriesNeeded = stateChangeEnergyPerGram * Amount;

        if (energyAmount >= caloriesNeeded)
        {
            State = isIce ? WaterState.Fluid : WaterState.Gas;
            return energyAmount - caloriesNeeded;
        }

        VolumeOfFirstState = 1 - energyAmount / caloriesNeeded;
        State = isIce ? WaterState.IceAndFluid : WaterState.FluidAndGas;
        return 0;
    }

    private double HeatTo(double energyAmount, int temperature)
    {
        if (energyAmount <= 0) return 0;
        var energyUsedToHeat = (temperature - Temperature) * Amount;
        if (!(energyAmount >= energyUsedToHeat)) return HeatMax(energyAmount);
        Temperature = temperature;
        return energyAmount - energyUsedToHeat;
    }

    private double HeatMax(double energyAmount)
    {
        if (energyAmount <= 0) return 0;
        var temperatureChange = energyAmount / Amount;
        Temperature += temperatureChange;
        return 0;
    }


    public enum WaterState
    {
        Fluid, Ice, Gas, FluidAndGas, IceAndFluid
    }

}