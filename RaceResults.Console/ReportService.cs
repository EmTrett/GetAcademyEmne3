#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
#pragma warning disable CS8629 // Nullable value type may be null.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace RaceResults.Console;

public class ReportService
{
    private readonly ResultService _results = new ("timedate.csv");

    public void ShowReport()
    {
        var didNotFinish = new List<TimeMeasurement?>();
        var finished = new List<TimeMeasurement?>();
        SortIfFinished(didNotFinish, finished);

        ShowNoFinishButStarter(didNotFinish);
        ShowFinished(finished);
    }

    private void ShowNoFinishButStarter(List<TimeMeasurement> timeMeasurements)
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

    private void ShowFinished(List<TimeMeasurement?> finished)
    {
        finished.Sort(Compare);
        System.Console.WriteLine("Startnr Tid");
        foreach (var timeMeasurement in finished)
        {
            System.Console.WriteLine($"{timeMeasurement.BibNumber,7} {timeMeasurement.ElapsedTime()}");
        }

        return;

        int Compare(TimeMeasurement tmA, TimeMeasurement tmB)
        {
            var elapsedA = tmA.TimeAt10K.Value.ToTimeSpan() - tmA.TimeAtStart.Value.ToTimeSpan();
            var elapsedB = tmB.TimeAt10K.Value.ToTimeSpan() - tmB.TimeAtStart.Value.ToTimeSpan();
            return Convert.ToInt32(elapsedA.TotalMilliseconds - elapsedB.TotalMilliseconds);
        }
    }

    private void SortIfFinished(List<TimeMeasurement?> didNotFinish, List<TimeMeasurement?> finished)
    {
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
    }
}