using System;
using System.Collections.Generic;

class Program
{
    class ToSort : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }

            // CompareTo() method
            return x.CompareTo(y);

        }
    }
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

        // Minimum POSITIVE number in the list -stretch 1
        int minimumNumber = -1;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                minimumNumber = number;
            }
            if ((number > 0) && (number < minimumNumber))
            {
                minimumNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {minimumNumber}");

        // Sorted list - stretch 2
        ToSort sorting = new ToSort();
        numbers.Sort(sorting);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}