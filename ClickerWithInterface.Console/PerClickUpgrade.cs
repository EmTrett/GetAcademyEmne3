namespace ClickerWithInterface.Console;

public class PerClickUpgrade(ClickerGame game) : ICommands
{
    private ClickerGame _game = game;
    public char Command { get; } = 'K';

    public void Run()
    {
        game.PerClickUpgrade();
    }
}