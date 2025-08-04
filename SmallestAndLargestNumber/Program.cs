using System;

class MinMaxInArray
{
    public static void Main(string[] args) 
    {
        //int[] numbers = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20];
        int[] numbers = new int[20];
        for(int i = 0; i < 20; i++)
        {
            numbers[i] = i + 1;
        }
        int minNumber = numbers.Min();
        int maxNumber = numbers.Max();

        Console.WriteLine($"Smallest Number : {minNumber}");
        Console.WriteLine($"Largest Number : {maxNumber}");

        Console.ReadLine();
    }
}