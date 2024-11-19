using GetAcademyEmne3.Assignments.Assignments323.Assignment323A;

namespace GetAcademyEmne3.Assignments.Assignment323.Assignment323A;

public class Assignment323A
{
    public static void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine()?.ToUpper();
        var match = new Match(bet);

        var matchIsRunning = true;
        while (matchIsRunning)
        {
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var command = Console.ReadLine()?.ToUpper();
            matchIsRunning = command != "X";
            if (command == "H") match.AddHomeGoals();
            else if (command == "B") match.AddAwayGoals();
            Console.WriteLine($"Stillingen er {match.HomeGoals}-{match.AwayGoals}.");
        }

        var isBetCorrect = match.IsBetCorrect();
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        Console.WriteLine($"Du tippet {isBetCorrectText}");
    }
}