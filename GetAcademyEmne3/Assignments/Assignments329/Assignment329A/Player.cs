namespace GetAcademyEmne3.Assignments.Assignments329.Assignment329A;

public class Player(string playerName, int playerScore)
{
    private int _playerScore = playerScore;
    private string _playerName = playerName;

    Random random = new Random();
    public void Play(Player eniemePlayer)
    {
        var randomBetween0to100 = random.Next(0, 100);

        if (randomBetween0to100 <= 50)
        {
            eniemePlayer.TakeOneDamage();
            _playerScore++;
        }
        else
        {
            _playerScore--;
            eniemePlayer._playerScore++;
        }
    }

    private void TakeOneDamage()
    {
        _playerScore--;
    }

    public void ShowNameAndPoints()
    {
        Console.WriteLine($"Player {_playerName} has score: {_playerScore}");
    }
}