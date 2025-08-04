using System;
using System.Collections.Generic;
using System.Linq;

class CalculatorApp
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to input: ");
        int n;

        // Validate input for n
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        List<double> numbers = new List<double>();

        Console.WriteLine($"Enter {n} numbers (press Enter after each):");

        for (int i = 0; i < n; i++)
        {
            double num;
            Console.Write($"Number {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input. Please enter a number: ");
            }
            numbers.Add(num);
        }

        // Calculations
        double sum = numbers.Sum();
        double diff = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            diff -= numbers[i];
        }

        double avg = sum / n;
        double max = numbers.Max();
        double min = numbers.Min();
        double product = numbers.Aggregate(1.0, (acc, val) => acc * val);

        // Output
        Console.WriteLine("\n Results:");
        Console.WriteLine($"Sum      : {sum}");
        Console.WriteLine($"Diff     : {diff}");
        Console.WriteLine($"Average  : {avg}");
        Console.WriteLine($"Max      : {max}");
        Console.WriteLine($"Min      : {min}");
        Console.WriteLine($"Product  : {product}");
    }
}