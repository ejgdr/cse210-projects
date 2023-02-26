public class BreathingActivity : Activity
{
    private int _durationBreathing;
    private string[] _results;

    public BreathingActivity(int duration) : base(duration)
    {
        _durationBreathing = duration;
    }

    public void BreathingProcess()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);
    
    }
}