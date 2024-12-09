namespace ClickerWithInterface.Console;

public class ExitApp : ICommands
{
    public void Run()
    {
        Environment.Exit(0);
    }

    public char Command { get; } = 'X';
}