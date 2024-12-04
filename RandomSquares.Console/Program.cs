// See https://aka.ms/new-console-template for more information

namespace RandomSquares.Console;

public static class Program
{
    private static int _width = 40;
    private static int _height = 20;

    private static void Main()
    {
        while (true)
        {
            var boxes = CreateBoxes();
            Show(boxes);
            System.Console.WriteLine("(press enter for new. ctrl+c=exit)");
            System.Console.ReadLine();
        }
        // ReSharper disable once FunctionNeverReturns
    }
    

    private static
        Box[] CreateBoxes()
    {
        var random = new Random();
        var boxes = new Box[3];
        for (var i = 0; i < boxes.Length; i++)
        {
            boxes[i] = new Box(random, _width, _height);
        }
        return boxes;
    }

    private static void Show(Box[] boxes)
    {
        var screen = new VirtualScreen(_width,_height);
        foreach (var box in boxes)
        {
            screen.Add(box);
        }
        screen.Show();
    }
}