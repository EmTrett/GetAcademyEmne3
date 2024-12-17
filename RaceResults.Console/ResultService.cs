namespace RaceResults.Console;


internal class ResultService
{
    public readonly List<TimeMeasurement?> TimeMeasurements;

    public ResultService(string[] lines)
    {
        TimeMeasurements = new List<TimeMeasurement?>();
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            var bibNumber = int.Parse(parts[0]);
            var time = TimeOnly.Parse(parts[1]);
            var km = int.Parse(parts[2]);
            if (CheckIfAlreadyExistingTimeMeasurement(bibNumber))
            {
                var tm = GetTimeMeasurement(bibNumber);
                tm.ChangeTime(time, km);
                continue;
            }
            TimeMeasurements.Add(new TimeMeasurement(bibNumber, time, km));
        }
    }

    private bool CheckIfAlreadyExistingTimeMeasurement(int bibNumber)
    {
        foreach (var tm in TimeMeasurements)
        {
            if (tm.BibNumber == bibNumber) return true;
        }
        return false;
    }

    private TimeMeasurement? GetTimeMeasurement(int bibNumber)
    {
        foreach (var tm in TimeMeasurements)
        {
            if (tm.BibNumber == bibNumber) return tm;
        }
        return null;
    }
}