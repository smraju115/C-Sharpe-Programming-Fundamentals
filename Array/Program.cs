using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        // Input
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Sum and Average
        int sum = 0;
        foreach (int num in numbers)
            sum += num;

        double average = (double)sum / n;

        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Average: {average:F2}");

        // Ascending Sort
        Array.Sort(numbers);
        Console.WriteLine("\nSorted in Ascending Order:");
        foreach (int num in numbers)
            Console.Write(num + " ");

        // Descending Sort
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine("\n\nSorted in Descending Order:");
        foreach (int num in numbers)
            Console.Write(num + " ");

        // Reverse Array
        Console.WriteLine("\n\nArray in Reverse:");
        for (int i = n - 1; i >= 0; i--)
            Console.Write(numbers[i] + " ");
    }
}