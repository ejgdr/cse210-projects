using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference();

        Console.WriteLine(_reference.GenerateReference());

        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();
        if (input == "quit")
        {
            Console.WriteLine("");
        }
    }
}