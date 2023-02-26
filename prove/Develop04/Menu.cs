public class Menu
{
    public int _selection;

    public Dictionary<string, string> textNeeded = new Dictionary<string, string>()
    {
        {"Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."},
        {"Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."},
        {"Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."}
    };

    public Menu()
    {

    }

    public void DisplayMenu()
    {
        while (_selection != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _selection = int.Parse(Console.ReadLine());
            Console.Clear();
            if (_selection == 1)
            {
                Activity breathing = new Activity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.StartingMessage();
                breathing.AskDuration();

            }
            else if (_selection == 2)
            {
                Activity reflecting = new Activity("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.StartingMessage();
                reflecting.AskDuration();
            }
            else if (_selection == 3)
            {
                Activity listing = new Activity("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.StartingMessage();
                listing.AskDuration();
            }
            else if (_selection == 4)
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