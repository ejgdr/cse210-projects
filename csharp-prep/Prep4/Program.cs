using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create the list
        List<int> numbers = new List<int>();
        // Have a way out, when this variable is equal to 0, we stop adding numbers to the list
        int matchOperator = -1;

        // Add numbers to the list
        while (matchOperator != 0)
        {
            Console.Write("Enter number: ");
            matchOperator = int.Parse(Console.ReadLine());

            if (matchOperator != 0)
            {
                numbers.Add(matchOperator);
            }
        }

        // For the results: 
        // Sum of the list
        int sumList = 0;
        foreach (int number in numbers)
        {
            sumList += number;
        }
        Console.WriteLine($"The sum is: {sumList}");

        // Average of the list
        float averageList = ((float)sumList) / numbers.Count;
        Console.WriteLine($"The average is: {averageList}");

        // Maximum number in the list
        int maximumNumber = -1;
        foreach (int number in numbers)
        {
            if (number > maximumNumber)
            {
                maximumNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {maximumNumber}");
    }
}