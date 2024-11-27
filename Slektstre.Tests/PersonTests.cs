using Slektstre.Console;

namespace Slektstre.Tests;

public class Tests
{
    [Test]
    public void TestAllFields()
    {
        var p = new Person
        {
            Id = 17,
            FirstName = "Ola",
            LastName = "Nordmann",
            BirthYear = 2000,
            DeathYear = 3000,
            Father = new Person() { Id = 23, FirstName = "Per" },
            Mother = new Person() { Id = 29, FirstName = "Lise" },
        };

        var actualDescription = p.GetDescription();
        var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

        Assert.That(actualDescription, Is.EqualTo(expectedDescription));
    }
    
    [Test]
    public void TestNoFields()
    {
        var p = new Person
        {
            Id = 1,
        };

        var actualDescription = p.GetDescription();
        var expectedDescription = "(Id=1)";

        Assert.That(actualDescription, Is.EqualTo(expectedDescription));
    }

    [Test]
    public void TestSomeEmptyFields()
    {
        var p = new Person
        {
            Id = 17,
            FirstName = "Ole",
            Father = new Person() { Id = 23, FirstName = "Per" },
            BirthYear = 2000,
        };
        var actualDescription = p.GetDescription();
        var expectedDescription = "Ole (Id=17) Født: 2000 Far: Per (Id=23)";
        
        Assert.That(actualDescription, Is.EqualTo(expectedDescription));
    }
}