using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // First list
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };

        // Second list
        List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };

        // Method 1: Using HashSet (fast and simple)
        HashSet<int> mergedSet = new HashSet<int>(list1);
        mergedSet.UnionWith(list2);

        Console.WriteLine("Merged List (No Duplicates): " + string.Join(", ", mergedSet));

        // Optional Method 2: Using LINQ (if you prefer functional style)
        // var mergedList = list1.Concat(list2).Distinct().ToList();
        // Console.WriteLine("Merged List (No Duplicates): " + string.Join(", ", mergedList));
    }
}