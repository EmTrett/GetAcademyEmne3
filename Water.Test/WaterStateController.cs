namespace Water.Test;
using Water.Console;

public class Tests
{
    [Test]
    public void Test01WaterAt20Degrees()
    {
        var water = new Water(50, 20);
        Assert.That(water.State == Water.WaterState.Fluid);
        Assert.That(water.Temperature == 20);
        Assert.That(water.Amount == 50);
        
    }
}