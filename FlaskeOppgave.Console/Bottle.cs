namespace FlaskeOppgave.Console;

public class Bottle(int size)
{
    public int Size { get; private set; } = size;
    public int Content { get; set; } = 0;

    public void FillToTopFromTap()
    {
        Content = Size;
    }

    public int Empty()
    {
        var currentFilledAmount = Content;
        Content = 0;
        
        return currentFilledAmount;
    }

    public void Fill(int fillIn)
    {
        Content = fillIn;
    }

    public void FillToTop(Bottle bottle)
    {
        var currentAmountToBeFilled = Size - Content;
        bottle.EmptySetAmount(currentAmountToBeFilled);
        Content += currentAmountToBeFilled;
    }

    private void EmptySetAmount(int currentAmountToBeFilled)
    {
        Content -= currentAmountToBeFilled;
    }
}