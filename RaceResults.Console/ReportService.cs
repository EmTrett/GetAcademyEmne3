namespace RaceResults.Console;

public class ReportService
{
    private readonly ResultService _results = new ("timedate.csv");

    public void ShowReport()
    {
        var didNotFinish = new List<TimeMeasurement?>();
        var finished = new List<TimeMeasurement?>();
        foreach (var timeMeasurement in _results.TimeMeasurements)
        {
            if (timeMeasurement.TimeAt10K == null &&
                (timeMeasurement.TimeAt5K != null ||
                 timeMeasurement.TimeAtStart != null))
            {
                didNotFinish.Add(timeMeasurement);
            }

            if (timeMeasurement.TimeAt10K != null
                && timeMeasurement.TimeAtStart != null)
            {
                finished.Add(timeMeasurement);
            }
        }

        showNotFinishedButStarted(didNotFinish);
        finished.Sort(Compare);
        System.Console.WriteLine("Startnr Tid");
        foreach (var timeMeasurement in finished)
        {
            System.Console.WriteLine($"{timeMeasurement.BibNumber,7} {timeMeasurement.ElapsedTime()}");
        }

        void showNotFinishedButStarted(List<TimeMeasurement?> didNotFinish)
        {
            foreach (var timeMeasurement in didNotFinish)
            {
                if (timeMeasurement.TimeAt5K == null)
                {
                    System.Console.WriteLine($"Startnr {timeMeasurement.BibNumber}. Ble ikke ferdig");
                }
                else
                {
                    System.Console.WriteLine(
                        $"Startnr {timeMeasurement.BibNumber}: 5km tid {timeMeasurement.ElapsedTime()}. Ble ikke ferdig");
                }
            }

            System.Console.WriteLine("_________________________________________________________________________");
        }
        static int Compare(TimeMeasurement tmA, TimeMeasurement tmB)
        {
            var elapsedA = tmA.TimeAt10K.Value.ToTimeSpan() - tmA.TimeAtStart.Value.ToTimeSpan();
            var elapsedB = tmB.TimeAt10K.Value.ToTimeSpan() - tmB.TimeAtStart.Value.ToTimeSpan();
            return Convert.ToInt32(elapsedA.TotalMilliseconds - elapsedB.TotalMilliseconds);
        }
    }
}