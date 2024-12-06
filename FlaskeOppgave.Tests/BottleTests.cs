using FlaskeOppgave.Console;

namespace FlaskeOppgave.Tests;

public class Tests
{

    [Test]
    public void TestBottleSize()
    {
        var bottle = new Bottle(5);

        var sizeExpected = 5;
        var bottleSizeActual = bottle.Size;
        
        Assert.That(bottleSizeActual, Is.EqualTo(sizeExpected));
    }

    [Test]
    public void TestBottleContent()
    {
        var bottle = new Bottle(5);
        
        var filledExpected = 0;
        var bottleContentActual = bottle.Content;
        
        Assert.That(bottleContentActual, Is.EqualTo(filledExpected));
    }

    [Test]
    public void TestFillBottle()
    {
        var bottle = new Bottle(5);

        bottle.FillToTopFromTap();
        
        var filledExpected = 5;
        var bottleContentActual = bottle.Content;
        
        Assert.That(bottleContentActual, Is.EqualTo(filledExpected));
    }

    [Test]
    public void TestEmptyBottle()
    {
        var bottle = new Bottle(7);
        
        bottle.FillToTopFromTap();
        bottle.Empty();
        
        var filledExpected = 0;
        var bottleContentActual = bottle.Content;
        
        Assert.That(bottleContentActual, Is.EqualTo(filledExpected));
    }

    [Test]
    public void TestFillFromOtherBottle()
    {
        var bottle1 = new Bottle(5);
        var bottle2 = new Bottle(7);
        
        bottle1.FillToTopFromTap();
        bottle2.Fill(bottle1.Empty());
        
        var filledBottle1Expected = 0;
        var filledBottle2Expected = 5;
        var bottle1ContentActual = bottle1.Content;
        var bottle2ContentActual = bottle2.Content;
        
        Assert.That(bottle1ContentActual, Is.EqualTo(filledBottle1Expected));
        Assert.That(bottle2ContentActual, Is.EqualTo(filledBottle2Expected));
    }

    [Test]
    public void TestFillToTopFromOtherBottle()
    {
        var bottle1 = new Bottle(5);
        var bottle2 = new Bottle(7)
        {
            Content = 4
        };

        bottle1.FillToTopFromTap();
        bottle2.FillToTop(bottle1);
        
        var filledBottle1Expected = 2;
        var filledBottle2Expected = 7;
        var bottle1ContentActual = bottle1.Content;
        var bottle2ContentActual = bottle2.Content;
        
        Assert.That(bottle1ContentActual, Is.EqualTo(filledBottle1Expected));
        Assert.That(bottle2ContentActual, Is.EqualTo(filledBottle2Expected));
    }
}