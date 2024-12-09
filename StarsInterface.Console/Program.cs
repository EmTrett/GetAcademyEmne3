namespace StarsInterface.Console
{
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new IStars[]
            {
                new PhasesStar(random),
                new PhasesStar(random),
                new PhasesStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
            };
            while (true)
            {
                System.Console.Clear();     
                foreach (var star in stars)
                {
                    star.Update();
                    star.Show();
                }
                System.Console.CursorLeft = 0;
                System.Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}