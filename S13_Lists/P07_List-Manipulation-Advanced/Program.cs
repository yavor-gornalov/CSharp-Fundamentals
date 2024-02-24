using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> initialArray = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToList();
        List<int> modifiedArray = new List<int>();
        modifiedArray.AddRange(initialArray);

        Dictionary<string, Func<List<int>, string[], List<int>>> mapper = new() {
            { "Add" , AddElement },
            { "Remove", RemoveElement },
            { "RemoveAt", RemoveElementAtindex },
            { "Insert", InsertElementAtIndex },
            { "Contains" , IsArrContainsNumber },
            { "PrintEven", PrintEvenNumbers },
            { "PrintOdd", PrintOddNumbers },
            { "GetSum", SumArrayElements },
            { "Filter", GetFilteredArray },
        };

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            {
                if (!initialArray.SequenceEqual(modifiedArray))
                {
                    Console.WriteLine(string.Join(" ", modifiedArray));
                }
                return;
            }

            string[] tokens = line.Split().ToArray();
            string command = tokens[0];
            modifiedArray = mapper[command](modifiedArray, tokens.Skip(1).ToArray());
        }
    }

    static List<int> AddElement(List<int> nums, string[] tokens)
    {
        nums.Add(int.Parse(tokens[0]));
        return nums;
    }

    static List<int> RemoveElement(List<int> nums, string[] tokens)
    {
        nums.Remove(int.Parse(tokens[0]));
        return nums;
    }

    static List<int> RemoveElementAtindex(List<int> nums, string[] tokens)
    {
        nums.RemoveAt(int.Parse(tokens[0]));
        return nums;
    }

    static List<int> InsertElementAtIndex(List<int> nums, string[] tokens)
    {
        nums.Insert(int.Parse(tokens[1]), int.Parse(tokens[0]));
        return nums;
    }


    static List<int> IsArrContainsNumber(List<int> nums, string[] tokens)
    {
        int numberToCheck = int.Parse(tokens[0]);
        bool contains = nums.Contains(numberToCheck);
        Console.WriteLine(contains ? "Yes" : "No such number");
        return nums;
    }

    static List<int> PrintEvenNumbers(List<int> nums, string[] tokens)
    {
        List<int> evenNumbers = nums.Where(x => x % 2 == 0).ToList();
        Console.WriteLine(string.Join(" ", evenNumbers));
        return nums;
    }

    static List<int> PrintOddNumbers(List<int> nums, string[] tokens)
    {
        List<int> oddNumbers = nums.Where(x => x % 2 != 0).ToList();
        Console.WriteLine(string.Join(" ", oddNumbers));
        return nums;
    }

    static List<int> SumArrayElements(List<int> nums, string[] tokens)
    {
        int sum = nums.Sum();
        Console.WriteLine(sum);
        return nums;
    }

    static List<int> GetFilteredArray(List<int> nums, string[] tokens)
    {
        string condition = tokens[0];
        int limit = int.Parse(tokens[1]);
        List<int> filteredArray = new List<int>();
        switch (condition)
        {
            case "<":
                filteredArray = nums.Where(x => x < limit).ToList();
                break;
            case "<=":
                filteredArray = nums.Where(x => x <= limit).ToList();
                break;
            case ">":
                filteredArray = nums.Where(x => x > limit).ToList();
                break;
            case ">=":
                filteredArray = nums.Where(x => x >= limit).ToList();
                break;
        }
        Console.WriteLine(string.Join(" ", filteredArray));
        return nums;
    }
}
