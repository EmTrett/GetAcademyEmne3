namespace GetAcademyEmne3.Assignments.Assignment315I;

public static class ArgumentChecks
{
    public static void ShowHelpText()
    {
        const string infoText = "PasswordGenerator  \nOptions:\n- l = liten bokstav\n- L = stor bokstav\n- d = siffer\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\nEksempel: PasswordGenerator 14 lLssdd\n    betyr\n        Min. 1 liten bokstav\n        Min. 1 1 stor bokstav\n        Min. 2 spesialtegn\n        Min. 2 sifre\n        Lengde på passordet skal være 14";
        Console.WriteLine(infoText);
    }
    public static bool IsValid(string[] args)
    {
        if (args.Length != 2) return false;
        var firstArgument = args[0];
        var secondArgument = args[1];
        var firstCheck = FirstArgumentIsNumber(firstArgument);
        var secondCheck = SecondArgumentIsValidCharacters(secondArgument);
        
        return firstCheck && secondCheck;
    }
    
    private static bool FirstArgumentIsNumber(string firstArgument)
    {
        foreach (var c in firstArgument)
        {
            if(char.IsDigit(c)) continue;
            else return false;
        }

        return true;
    }

    private static bool SecondArgumentIsValidCharacters(string secondArgument)
    {
        var validCharacters = new []{'l','L','s','d'};

        return secondArgument.All(c => validCharacters.Contains(c));
    }
}