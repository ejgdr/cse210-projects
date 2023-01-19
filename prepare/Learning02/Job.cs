public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _entryYear;
    public int _outYear;
    public Job()
    {
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_entryYear}-{_outYear}");
    }
}