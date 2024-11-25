namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323C;

public class Assignment323C
{
    public static void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);

        while (true)
        {
            gameConsole.Show(board);
            Console.Write("Skriv inn hvor du vil sette kryss f.eks \"a2\"):");
            var position = Console.ReadLine().ToUpper();
            board.Mark(position);
        }
    }
}