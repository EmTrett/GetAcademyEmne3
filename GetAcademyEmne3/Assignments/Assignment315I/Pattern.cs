namespace GetAcademyEmne3.Assignments.Assignment315I;

public static class Pattern
{
    public static string CreatePassword(string pattern, int length)
    {
        var password = "";
        while (pattern.Length < length)
        {
            pattern += 'l';
        }

        foreach (var c in pattern)
        {
            switch (c)
            {
                case 'l':
                    password += WriteRandom.LowerCaseLetter();
                    break;
                case 'L':
                    password += WriteRandom.UpperCaseLetter();
                    break;
                case 'd':
                    password += WriteRandom.Digit();
                    break;
                case 's':
                    password += WriteRandom.Symbol();
                    break;
            }
        }
        return password;
    }
}