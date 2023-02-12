public class StopWatch
{

    public DateTime StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public void Start()
    {
        this.StartTime = DateTime.Now;
    }

    public TimeSpan Stop()
    {
        return DateTime.Now - this.StartTime;
    }

}
