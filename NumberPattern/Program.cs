using System;

public class NumberPattern
{
    public static void Main(string[] args)
    {
        int currentNumber = 1;
        for (int row = 1; row <= 4; row++) 
        {
            for (int col = 1; col <= row; col++) 
            {
                Console.Write(currentNumber);
                currentNumber++;
            }
            Console.WriteLine(""); 
        }
        Console.ReadLine();
    }
}