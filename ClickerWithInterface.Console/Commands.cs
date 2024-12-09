namespace ClickerWithInterface.Console;

public class Commands(ClickerGame game)
{
    private ICommands[] _commands =
    [
        new ExitApp(),
        new Click(game),
        new PerClickUpgrade(game),
        new PerClickIncreaseUpgrade(game)
    ];

    public void Run(char commandChar)
    {
        var command = GetCommandType(commandChar);
        if (command != null) command.Run();
    }

    private ICommands GetCommandType(char commandChar)
    {
        foreach (var command in _commands)
        {
            if(command.Command == commandChar) return command;
        }
        return null;
    }
}