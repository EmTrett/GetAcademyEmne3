using RandomSquares.Console;

namespace RandomSquares.Tests;

public class Tests
{

    [Test]
    public void TestOverlapCharacters()
    {
        var crossCell = new VirtualScreenCell();
        var verticalWithRightTurn = new VirtualScreenCell();
        var verticalWithLeftTurn = new VirtualScreenCell();
        var horizontalWithDownTurn = new VirtualScreenCell();
        var horizontalWithUpTurn = new VirtualScreenCell();
        
        crossCell.AddHorizontal();
        crossCell.AddVertical();
        
        verticalWithLeftTurn.AddVertical();
        verticalWithLeftTurn.AddLowerRightCorner();
        
        verticalWithRightTurn.AddVertical();
        verticalWithRightTurn.AddLowerLeftCorner();
        
        horizontalWithUpTurn.AddHorizontal();
        horizontalWithUpTurn.AddLowerRightCorner();
        
        horizontalWithDownTurn.AddHorizontal();
        horizontalWithDownTurn.AddUpperRightCorner();
        
        var crossCellActualChar = crossCell.GetCharacter();
        var expectedCrossChar = '\u253c';
        
        var verticalWithLeftTurnActualChar = verticalWithLeftTurn.GetCharacter();
        var expectedVerticalWithLeftTurnChar = '\u2524';
        
        var verticalWithRightTurnActualChar = verticalWithRightTurn.GetCharacter();
        var expectedVerticalWithRightTurnChar = '\u251c';
        
        var horizontalWithRightTurnActualChar = horizontalWithUpTurn.GetCharacter();
        var expectedHorizontalWithRightTurnChar = '\u2534';
        
        var horizontalWithDownTurnActualChar = horizontalWithDownTurn.GetCharacter();
        var expectedHorizontalWithDownTurnChar = '\u252c';
        
        
        Assert.That(crossCellActualChar, Is.EqualTo(expectedCrossChar));
        Assert.That(verticalWithLeftTurnActualChar, Is.EqualTo(expectedVerticalWithLeftTurnChar));
        Assert.That(horizontalWithRightTurnActualChar, Is.EqualTo(expectedHorizontalWithRightTurnChar));
        Assert.That(verticalWithRightTurnActualChar, Is.EqualTo(expectedVerticalWithRightTurnChar));
        Assert.That(horizontalWithDownTurnActualChar, Is.EqualTo(expectedHorizontalWithDownTurnChar));
    }

    [Test]
    public void TestTopLeftCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddUpperLeftCorner();

        var topLeftCharacterExpected = '\u250c';
        var topLeftCharacterActual = cell.GetCharacter();
        
        Assert.That(topLeftCharacterActual, Is.EqualTo(topLeftCharacterExpected));
    }
    
    [Test]
    public void TestBottomLeftCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddLowerLeftCorner();
        
        var bottomLeftCharacterExpected = '\u2514';
        var bottomLeftCharacterActual = cell.GetCharacter();
        
        Assert.That(bottomLeftCharacterActual, Is.EqualTo(bottomLeftCharacterExpected));
    }

    [Test]
    public void TestTopRightCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddUpperRightCorner();
        
        var topRightCharacterExpected = '\u2510';
        var topRightCharacterActual = cell.GetCharacter();
        
        Assert.That(topRightCharacterActual, Is.EqualTo(topRightCharacterExpected));
    }

    [Test]
    public void TestBottomRightCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddLowerRightCorner();
        
        var bottomRightCharacterExpected = '\u2518';
        var bottomRightCharacterActual = cell.GetCharacter();
        
        Assert.That(bottomRightCharacterActual, Is.EqualTo(bottomRightCharacterExpected));
    }

    [Test]
    public void TestHorizontalCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddHorizontal();
        
        var horizontalCharacterExpected = '\u2500';
        var horizontalCharacterActual = cell.GetCharacter();
        
        Assert.That(horizontalCharacterActual, Is.EqualTo(horizontalCharacterExpected));
    }

    [Test]
    public void TestVerticalCharacter()
    {
        var cell = new VirtualScreenCell();
        
        cell.AddVertical();
        
        var verticalCharacterExpected = '\u2502';
        var verticalCharacterActual = cell.GetCharacter();
        
        Assert.That(verticalCharacterActual, Is.EqualTo(verticalCharacterExpected));
    }
}