using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Input array elements
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter the number to search: ");
        int searchValue = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == searchValue)
            {
                Console.WriteLine($"Number {searchValue} found at index {i}.");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine($"Number {searchValue} not found in the array.");
    }
}