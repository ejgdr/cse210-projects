using System;

class Program
{
    static void Main(string[] args)
    {
        // iterator to play again
        string game = "yes";

        // Random number
        Random randomGenerator = new Random();

        while (game == "yes")
        {
            // I need a seed guess with a number I am sure will not be taken at first
            int guess = -1;

            // Keep track of how many guesses there are - stretch 1
            int count = 0;

            // Use the random number for the magic number
            int magicNumber = randomGenerator.Next(1, 100);

            // Iterate while the guess is different from magic number

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You got it in {count} guesses!");
            Console.Write("Would you like to play again?(yes/no) ");
            game = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing! Come back soon :)");
    }
}