using System.Windows.Input;

namespace ClickerWithInterface.Console;

public class Click(ClickerGame game) : ICommands
{
    public char Command { get; } = ' ';
    public void Run()
    {
        game.Click();
    }
}