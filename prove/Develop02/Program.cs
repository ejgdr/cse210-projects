using System;

class Program
{
    static void Main(string[] args)
    {
        //It calls the Display Menu class to start the program and selection
        // As you can see I took one of my other classes to manage the Menu, and Journal take from Entry
        // My extra features are in the way we work with the saved files
        DisplayMenu menu = new DisplayMenu();
        Console.WriteLine("Welcome to the Journal Program!");
        menu.SelectFromMenu();
    }
}