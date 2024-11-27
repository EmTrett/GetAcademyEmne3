namespace Slektstre.Console;

public class FamilyApp(params Person[] people)
{
    private List<Person> _persons = people.ToList();

    public readonly string WelcomeMessage = "Welcome to Slektstre!";

    public readonly string CommandPrompt = " ";

    public string HandleCommand(string input)
    {
        string output = "";
        var id = GetNumbersFromString(input);
        var person = people.FirstOrDefault(p => p.Id == id);
        if (person == null) return "Fant ingen person med denne Id";
        
        output += person?.GetDescription();
        var children = GetChildrenFromPerson(person);
        if (children.Length <= 0) return output;
        output += $"\n";
        output += $"  Barn\n";
        foreach (var child in children)
        {
            output += $"    {child.GetDescription()} \n";
        }
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
                children.Add(_persons.First(p => p.Id == p.Father.Id));
            }

            if (p.Mother?.Id == person.Id)
            {
                children.Add(_persons.First(p => p.Id == p.Mother.Id));
            }
        }
        return children.ToArray();
    }
}