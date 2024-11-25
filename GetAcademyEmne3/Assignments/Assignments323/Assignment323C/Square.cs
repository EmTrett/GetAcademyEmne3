namespace GetAcademyEmne3.Assignments.Assignments323.Assignment323C;

public class Square
{
    private bool _isEmpty = true;
    private char _symbol = ' ';
    private bool _isPlayerOne;

    public void FillSquare()
    {
        if (!_isEmpty) return;
        _isEmpty = false;
        _symbol = _isPlayerOne ? 'X' : 'O';
    }

    public void SetPlayer(bool isPlayerOne)
    {
        _isPlayerOne = isPlayerOne;
    }

    public char Symbol => _symbol;
}