namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323C;

public class GameConsole(Board board)
{
    public void Show(Board board)
    {
        
        Console.Clear();
        Console.WriteLine(
            "  a b c \n" +
            $" \u250c\u2500\u2500\u2500\u2500\u2500\u2510 \n" +
            $"1\u2502{board.Squares[0].Symbol} {board.Squares[1].Symbol} {board.Squares[2].Symbol}\u2502 \n" +
            $"2\u2502{board.Squares[3].Symbol} {board.Squares[4].Symbol} {board.Squares[5].Symbol}\u2502 \n" +
            $"3\u2502{board.Squares[6].Symbol} {board.Squares[7].Symbol} {board.Squares[8].Symbol}\u2502 \n" +
            " \u2514\u2500\u2500\u2500\u2500\u2500\u2518");
    }
}