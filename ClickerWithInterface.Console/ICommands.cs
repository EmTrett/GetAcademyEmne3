namespace ClickerWithInterface.Console;

public interface ICommands
{
    void Run();
    char Command { get; }
}