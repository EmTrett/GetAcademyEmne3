namespace RaceResults.Console;

public class TimeMeasurement()
{
    public TimeMeasurement(int bibNumber, TimeOnly time, int km) : this()
    {
        BibNumber = bibNumber;
        if (km == 0) TimeAtStart = time;
        if (km == 5) TimeAt5K = time;
        if (km == 10) TimeAt10K = time;
    }
    public int BibNumber { get; private set; }
    public TimeOnly? TimeAtStart { get; }
    public TimeOnly? TimeAt5K { get; private set; }
    public TimeOnly? TimeAt10K { get; private set; }

    public void ChangeTime(TimeOnly time, int km)
    {
        if (km == 5) TimeAt5K = time;
        if (km == 10) TimeAt10K = time;
    }
    
    public TimeSpan ElapsedTime()
    {
        if(TimeAt10K != null)return TimeAt10K.Value.ToTimeSpan() - TimeAtStart.Value.ToTimeSpan();
        if(TimeAt5K != null)return TimeAt5K.Value.ToTimeSpan() - TimeAtStart.Value.ToTimeSpan();
        throw new Exception("TimeAtStart is null");
    }
}