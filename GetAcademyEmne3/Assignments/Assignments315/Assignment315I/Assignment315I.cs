namespace GetAcademyEmne3.Assignments.Assignment315I;

public class Assignment315I
{
    public static void Run(string[] args)
    {
        if (!ArgumentChecks.IsValid(args))
        {
            ArgumentChecks.ShowHelpText();
            return;
        }

        var requestedPasswordLenght = Convert.ToInt32(args[0]);
        var password = Pattern.CreatePassword(args[1], requestedPasswordLenght);

        Console.WriteLine($"Her har du et nytt passord: {password}");
    }
}