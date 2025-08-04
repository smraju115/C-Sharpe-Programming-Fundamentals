public class StringReverse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to reverse : ");
        string userInput = Console.ReadLine();

        char[] charArray = userInput.ToCharArray();

        Array.Reverse(charArray);

        string reversedString = new string(charArray);
        Console.WriteLine($"The reversed string is : { reversedString}");

    }
}