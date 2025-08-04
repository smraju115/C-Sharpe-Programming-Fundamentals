using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of blocks (N): ");
        int N = int.Parse(Console.ReadLine());

        long sum = 0;

        for (int n = 1; n <= N; n++)
        {
            int term = 4 * n - 1;
            sum += (long)(term * term); // (4n - 1)^2
        }

        Console.WriteLine($"The sum of the series is: {sum}");
    }
}
