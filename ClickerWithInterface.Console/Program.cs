using ClickerWithInterface.Console;

namespace ClickerWithInterface.Console;

class Program
{
    static void Main(string[] args)
    {
        var game = new ClickerGame();
        var commands = new Commands(game);
        while (true)
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            System.Console.WriteLine($"Du har {game.Points} poeng.");
            System.Console.WriteLine("Trykk tast for ønsket kommando.");
            var command = System.Console.ReadKey().KeyChar;
            commands.Run(command);
        }
    }
}