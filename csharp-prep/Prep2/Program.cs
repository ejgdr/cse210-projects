using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        float percentage = float.Parse(Console.ReadLine());
        string letter;

        // Logic for the grade letters
        if (percentage >= 0 && percentage < 60)
        {
            letter = "F";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 90 && percentage <= 100)
        {
            letter = "A";
        }
        else
        {
            letter = "Introduce a valid grade percentage";
        }

        // logic for the + & - symbols - stretch 1
        string symbol;
        float lastDigit = percentage % 10;
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

        // logic for taking out the symbols from A and F as needed - stretch 2 & 3
        if ((percentage >= 93 && letter == "A") || (letter == "F"))
        {
            symbol = "";
        }

        // logic for the output using letter and symbol - basic and added variable for stretch 1
        if (percentage >= 0 && percentage <= 100)
        {
            Console.WriteLine($"Your letter grade is {letter}{symbol}");
        }
        else
        {
            Console.WriteLine($"{letter}");
        }

        // logic for the congrats or the encouragement
        if (percentage >= 70 && percentage <= 100)
        {
            Console.WriteLine("Congratulations you passed");
        }
        else if (percentage >= 0 && percentage < 70)
        {
            Console.WriteLine("You'll get it next time");
        }
        else
        {
            Console.WriteLine(":(");
        }
    }
}