class Program
{
    static void Main()
    {
        string[] cras = { "BMW", "Marcedez Bench", "Mazda", "Mazda", "Hundai"};
        string[] rmvDuplicates = cras.Distinct().ToArray();

        Console.WriteLine(string.Join(", ", rmvDuplicates));
        Console.ReadLine();
    }
}


