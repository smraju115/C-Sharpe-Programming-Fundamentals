using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Get number of elements
        Console.Write("Enter how many numbers you want to input: ");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        // Input numbers
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }


        //Find Min and Max of List
        int Minimum = numbers.Min();
        int Maximum = numbers.Max();

        Console.WriteLine($"\nMinimum :{Minimum}");
        Console.WriteLine($"\nMaximum :{Maximum}");



        // Calculate sum and average
        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Average: {average:F2}");

        // Sort in ascending order
        List<int> ascending = new List<int>(numbers);
        ascending.Sort();
        Console.WriteLine("\nAscending Order: " + string.Join(", ", ascending));

        // Sort in descending order
        List<int> descending = new List<int>(numbers);
        descending.Sort();
        descending.Reverse();
        Console.WriteLine("Descending Order: " + string.Join(", ", descending));

        // Reverse original list
        List<int> reversed = new List<int>(numbers);
        reversed.Reverse();
        Console.WriteLine("Reversed Original Order: " + string.Join(", ", reversed));

        // Search for a number
        Console.Write("\nEnter a number to search: ");
        int searchNum = int.Parse(Console.ReadLine());

        if (numbers.Contains(searchNum))
        {
            int index = numbers.IndexOf(searchNum);
            Console.WriteLine($" Number {searchNum} found at index {index} in the original list.");
        }
        else
        {
            Console.WriteLine($" Number {searchNum} not found in the list.");
        }
    }
}