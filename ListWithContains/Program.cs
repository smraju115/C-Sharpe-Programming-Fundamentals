using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Apple", "BananA", "Avocado", "Mango", "Apricot", "Alma", "Papaya", "Aqua", "Berry"
        };

        // Strings that contain "A"
        var containsA = names.Where(s => s.Contains("A")).ToList();

        // Strings that start with "A"
        var startsWithA = names.Where(s => s.StartsWith("A")).ToList();

        // Strings that end with "A"
        var endsWithA = names.Where(s => s.EndsWith("A")).ToList();

        Console.WriteLine("Contains 'A': " + string.Join(", ", containsA));
        Console.WriteLine("Starts with 'A': " + string.Join(", ", startsWithA));
        Console.WriteLine("Ends with 'A': " + string.Join(", ", endsWithA));
    }
}