public class DisplayMenu
{
    // Variable to compare options from the user
    public int _option;

    public Entry _entry = new Entry();

    public Journal _journal = new Journal();

    public DisplayMenu()
    {
    }
    // Loop through the options until selection is equal to 5 to end the program
    public void SelectFromMenu()
    {
        while (_option != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            _option = int.Parse(Console.ReadLine());
            if (_option == 1)
            {
                _journal.AddToJournal();
            }
            else if (_option == 2)
            {
                _journal.DisplayJournal();
            }
            else if (_option == 3)
            {
                _journal.LoadData();
            }
            else if (_option == 4)
            {
                _journal.SaveData();
            }
            // Additional feature, to avoid crashing the program for wrong input
            else if (_option == 5)
            {
                Console.WriteLine("See you later!");
            }
            else
            {
                Console.WriteLine("Wrong input. Please introduce a number according to the menu");
            }
        }

    }
}