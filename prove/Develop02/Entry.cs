public class Entry
{
    // Class that collect the question and the answer of the user in one component
    public PromptGenerator _prompt = new PromptGenerator();

    public string _entryFromUser;
    public DateTime currentDate = DateTime.Now;
    public Entry()
    {
    }
    public string DisplayEntry()
    {
        string dateToday = currentDate.ToShortDateString();
        string promptK = _prompt.GenerateAleatoryPrompt();
        Console.WriteLine(promptK);
        Console.Write("> ");
        _entryFromUser = Console.ReadLine();
        return $"{dateToday} - {promptK}\n{_entryFromUser}\n";
    }
}