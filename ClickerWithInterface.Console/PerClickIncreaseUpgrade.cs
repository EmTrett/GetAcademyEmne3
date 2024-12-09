namespace ClickerWithInterface.Console;

public class PerClickIncreaseUpgrade(ClickerGame game) : ICommands
{
    public void Run()
    {
        game.PerClickIncreaseUpgrade();
    }

    public char Command { get; } = 'S';
}