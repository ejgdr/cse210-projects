public class Activity
{
    protected string _activityName;
    protected string _description;
    protected string _endMessage;
    protected int _duration;
    protected int _waitingTime;
    private List<string> spinnerAnimation = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public Activity (int duration)
    {
        _duration = duration;
    }

    public void StartingMessage()
    {
        string content = $"{_activityName}\n\n{_description}\n";
        Console.WriteLine(content);
    }

    public void AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }

    public void EndingMessage()
    {
        
    }
    public void ShowSpinner()
    {
        foreach (string s in spinnerAnimation)
        {
            Console.Write(s);
            Thread.Sleep(700);
            Console.Write("\b \b");
        }
    }
    public void ShowCountdown()
    {
        
    }
}