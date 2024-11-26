namespace Water.Console;

public class Water
{
    public Water(int waterAmount, int waterTemperature)
    {
        Amount = waterAmount;
        Temperature = waterTemperature;
        State = Temperature < +0 ? WaterState.Ice :
            Temperature > 100 ? WaterState.Gas :
            WaterState.Fluid;
    }
    public WaterState State { get; set; }

    public int Temperature { get; }
    public int Amount { get; }
    
    
    public enum WaterState
    {
        Fluid, Ice, Gas, FluidAndGas, IceAndFluid
    }
}