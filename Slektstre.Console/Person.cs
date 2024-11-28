namespace Slektstre.Console;

public class Person(
    string? firstName = default,
    int id = default,
    string? lastName = default,
    int birthYear = default,
    Person? father = default,
    Person? mother = default,
    int deathYear = default)
{
    public Person? Father { get; set; } = father;

    public Person? Mother { get; set; } = mother;

    public int DeathYear { get; set; } = deathYear;

    public int BirthYear { get; set; } = birthYear;

    public int Id { get; set; } = id;

    public string? LastName { get; set; } = lastName;

    public object? FirstName { get; set; } = firstName;

    public string GetDescription()
    {
        var description = "";
        if (FirstName != null) description += FirstName + " ";
        if (LastName != null) description += LastName + " ";
        if (Id != 0) description += $"(Id={Id})";
        if (BirthYear != 0) description += $" Født: {BirthYear}";
        if (DeathYear != 0) description += $" Død: {DeathYear}";
        if (Father != null) description += $" Far: {Father.FirstName} (Id={Father.Id})";
        if (Mother != null) description += $" Mor: {Mother.FirstName} (Id={Mother.Id})";
        
        return description;
    }

    public string GetChildDescription()
    {
        var description = "";
        if (FirstName != null) description += FirstName + " ";
        if (LastName != null) description += LastName + " ";
        if (Id != 0) description += $"(Id={Id})";
        if (BirthYear != 0) description += $" Født: {BirthYear}";
        
        return description;
    }
}