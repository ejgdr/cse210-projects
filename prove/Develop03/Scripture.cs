public class Scripture
{
    // This class will receive a string from Reference with the scripture to study
    // Member variables
    private string _scripture;
    private string[] _scriptureList;
    Random random = new Random();

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    private string[] AssembleVerses()
    {
        char[] delimiterChars = { ' ', '.', ',', ';', '\n' };
        string[] scriptureList = _scripture.Split(delimiterChars);
        return scriptureList;
    }

    public void HideWords(string[] scriptureList)
    {
        scriptureList = AssembleVerses();
        foreach (string word in scriptureList)
        {

        }

    }
}