namespace RaceResults.Console;

public static class WriteReportToConsole
{
    public static void ShowNoFinishButStarter(List<TimeMeasurement> timeMeasurements)
    {
        {
            foreach (var tm in timeMeasurements)
            {
                if (tm.TimeAt5K == null)
                {
                    System.Console.WriteLine($"Startnr {tm.BibNumber}. Ble ikke ferdig");
                }
                else
                {
                    System.Console.WriteLine(
                        $"Startnr {tm.BibNumber}: 5km tid {tm.ElapsedTime()}. Ble ikke ferdig");
                }
            }

            System.Console.WriteLine("_________________________________________________________________________");
        }
    }
    
    
    public static void ShowFinished(List<TimeMeasurement?> finished)
    {
        
        System.Console.WriteLine("Startnr Tid");
        foreach (var timeMeasurement in finished)
        {
            System.Console.WriteLine($"{timeMeasurement.BibNumber,7} {timeMeasurement.ElapsedTime()}");
        }
    }
}