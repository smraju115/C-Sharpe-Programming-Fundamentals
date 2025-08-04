using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");

        // Read user input and convert to integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"\nMultiplication Table for {number}:\n");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}