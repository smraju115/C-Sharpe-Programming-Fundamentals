// See https://aka.ms/new-console-template for more information
using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(0, 1000); // Generates a number between 0 and 999
        int userGuess = -1;

        Console.WriteLine(">>>Welcome To Guessing Game Zone<<<");
        Console.WriteLine("Guess the number (between 0 and 999):");

        while (userGuess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Validate input
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (userGuess < 0 || userGuess > 999)
            {
                Console.WriteLine("Your guess is out of range. Try a number between 0 and 999.");
                continue;
            }

            if (userGuess < targetNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userGuess > targetNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Congratulations 😍! You guessed the number!");
            }
        }
    }
}

