using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list with numbers from 1 to 20
        List<int> numbers = Enumerable.Range(1, 20).ToList();

        // Remove numbers divisible by 3
        List<int> filtered = numbers.Where(n => n % 3 != 0).ToList();

        // Print the result
        Console.WriteLine("Filtered List:");
        foreach (int num in filtered)
        {
            Console.Write(num + " ");
        }
    }
}