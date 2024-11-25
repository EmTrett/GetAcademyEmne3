namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323C;



public class Board
{
    public Square[] Squares = new Square[9].Select(h => new Square()).ToArray();
    private bool _playerTurn = false;
    public void Mark(string position)
    {
        _playerTurn = !_playerTurn;
        var i = GetPosition(position);
        Squares[i].SetPlayer(_playerTurn);
        Squares[i].FillSquare();
    }

    private int GetPosition(string position)
    {
        position = position.ToUpper();
        if(position == "A1") return 0;
        if(position == "B1") return 1;
        if(position == "C1") return 2;
        if(position == "A2") return 3;
        if(position == "B2") return 4;
        if(position == "C2") return 5;
        if(position == "A3") return 6;
        if(position == "B3") return 7;
        if(position == "C3") return 8;
        
        throw new Exception("Invalid position");
    }
}