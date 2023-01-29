using System.IO;
public class Journal
{
    // Class that manage all the options by logic, all operations related to Journal
    public List<string> _listOfEntries = new List<string>();

    public Entry _entryJ = new Entry();

    public Journal()
    {
    }
    public void AddToJournal()
    {
        string entry = _entryJ.DisplayEntry();
        _listOfEntries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (string list in _listOfEntries)
        {
            Console.WriteLine(list);
        }
    }
    public void SaveData()
    {
        // My extra feature is the work with the files if they exist and want to add to it
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();
        string file = fileName;
        if (File.Exists(file))
        {
            Console.Write("This file already exists. Would you like to add to it? (y/n): ");
            string option = Console.ReadLine();
            if (option == "y")
            {
                fileName = file;
            }
            else if (option == "n")
            {
                Console.Write("Please type the new file name: ");
                fileName = Console.ReadLine();
            }
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string record in _listOfEntries)
            {
                outputFile.WriteLine(record);
            }

        }
    }
    public void LoadData()
    {
        //My extra feature is avoid crashing the app if they forget the name of the file
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("That file doesn't exist, this are your current files in memory:");
            var path = ".";
            var fullPath = Path.GetFullPath(path);
            string[] files = Directory.GetFiles(fullPath, "*.txt", 0);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.Write("Please type the desired one (Ex: name.txt): ");
            fileName = Console.ReadLine();
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _listOfEntries.Clear();

        foreach (string line in lines)
        {
            _listOfEntries.Add(line);
        }

    }
}