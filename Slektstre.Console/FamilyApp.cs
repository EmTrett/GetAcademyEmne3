namespace Slektstre.Console;

public class FamilyApp(params Person[] people)
{
    private readonly List<Person> _persons = people.ToList();

    public readonly string WelcomeMessage = "Welcome to Slektstre! \n Skriv \"hjelp\" for liste av Kommandoer.";

    public readonly string CommandPrompt = "*\"liste\" => liste av alle personer som er registrert \n*\"vis Id\" viser bestemt person og registrerte barn \n";

    public string HandleCommand(string input)
    {
        input = input.ToLower();
        if (input.Contains("hjelp")) return CommandPrompt;
        if (input.Contains("liste")) return ShowAllPeoplesDescriptions();
        string output = "";
        var id = GetNumbersFromString(input);
        var person = people.FirstOrDefault(p => p.Id == id);
        if (person == null) return "Fant ingen person med denne Id";
        
        output += person.GetDescription();
        var children = GetChildrenFromPerson(person);
        if (children.Length <= 0) return output;
        output += $"\n";
        output += $"  Barn:\n";
        for (var index = 0; index < children.Length; index++)
        {
            var child = children[index];
            output += $"    {child.GetChildDescription()}\n";
        }

        return output;
    }

    private string ShowAllPeoplesDescriptions()
    {
        var output = "";
        var borderTopAndBottomLine = "************************************************************\n";
        
        output += borderTopAndBottomLine;
        foreach (var person in _persons)
        {
            output += person.GetDescription();
            output += "\n";
        }
        output += borderTopAndBottomLine;
        
        return output;
    }

    private int GetNumbersFromString(string input)
    {
        var numbers = "";
        foreach (var c in input)
        {
            if (c is >= '0' and <= '9')
            {
                numbers += c.ToString();
            }
        }
        
        var success = Int32.TryParse(numbers, out int number);
        return success ? number : 0;
    }

    private Person[] GetChildrenFromPerson(Person person)
    {
        var children = new List<Person>();
        
        foreach (var p in _persons)
        {
            if (p.Father?.Id == person.Id)
            {
                children.Add(p);
            }

            else if (p.Mother?.Id == person.Id)
            {
                children.Add(p);
            }
        }
        return children.ToArray();
    }
}