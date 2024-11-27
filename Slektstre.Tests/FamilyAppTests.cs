using Slektstre.Console;

namespace Slektstre.Tests;

public class FamilyAppTests
{
    [Test]
    public void FamilyAppTestId3WithoutChildren()
    {
        var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
        var familyApp = new FamilyApp(haakon);

        var actualResponse = familyApp.HandleCommand("vis 3");
        var expectedResponse = "Haakon Magnus (Id=3) Født: 1973";
        
        Assert.That(actualResponse, Is.EqualTo(expectedResponse));
    }

    [Test]
    public void FamilyAppTestId3WithChildren()
    {
        var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 2013 };
        var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
        var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1977 };
        
        haakon.Mother = metteMarit;
        haakon.Father = marius;
        
        var familyApp = new FamilyApp(haakon, metteMarit, marius);
        
        var actualResponse = familyApp.HandleCommand("vis 3");
        var expectedResponse = "Haakon Magnus (Id=3) Født: 2013 Far: Harald (Id=6)\n"
                               + "  Barn:\n"
                               + "    Marius (Id=5) Født: 1977\n"
                               + "    Mette-Marit (Id=4) Født: 1973\n";
    }
}