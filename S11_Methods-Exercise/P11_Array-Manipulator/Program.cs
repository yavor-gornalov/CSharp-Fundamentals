public class Program
{
    public static void Main()
    {
        List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();


        while (true)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split();
            string command = tokens[0];

            switch (command)
            {
                case "end":
                    {
                        PrintArray(array);
                        return;
                    }
                case "exchange":
                    {
                        int index = int.Parse(tokens[1]);
                        array = Exchange(array, index);
                        break;
                    }
                case "max":
                case "min":
                    {
                        string subcommand = tokens[1];
                        PrintMax(array, command, subcommand);
                        break;
                    }
                case "first":
                case "last":
                    {
                        int count = int.Parse(tokens[1]);
                        string subcommand = tokens[2];
                        PrintFilteredElements(array, command, subcommand, count);
                        break;
                    }

            }
        }
    }

    private static List<int> Exchange(List<int> elements, int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            List<int> firstPart = elements.GetRange(index + 1, elements.Count - index - 1);
            List<int> secondPart = elements.GetRange(0, index + 1);
            elements = firstPart.Concat(secondPart).ToList();
        }
        else
        {
            Console.WriteLine("Invalid index");
        }

        return elements;
    }

    private static void PrintMax(List<int> arr, string command, string subcommand)
    {
        List<int> sortedSeq = new List<int>();
        if (command == "max")
        {
            if (subcommand == "even")
            {
                sortedSeq = arr.Where(x => x % 2 == 0).OrderByDescending(x => x).ToList();

            }
            if (subcommand == "odd")
            {
                sortedSeq = arr.Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();
            }
        }

        if (command == "min")
        {
            if (subcommand == "even")
            {
                sortedSeq = arr.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            }
            if (subcommand == "odd")
            {
                sortedSeq = arr.Where(x => x % 2 != 0).OrderBy(x => x).ToList();
            }
        }
        if (sortedSeq.Count > 0)
        {
            int optimumIdx = -1;
            int idx = 0;
            foreach (int num in arr)
            {
                if (num == sortedSeq[0]) optimumIdx = idx;
                idx++;
            }
            Console.WriteLine(optimumIdx);
        }
        else Console.WriteLine("No matches");
    }

    private static void PrintFilteredElements(List<int> arr, string command, string subcommand, int count)
    {
        if (count <= 0 || count > arr.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        List<int> result = new List<int>();
        foreach (int num in arr)
        {
            if (subcommand == "even" && num % 2 == 0)
            {
                result.Add(num);
            }
            if (subcommand == "odd" && num % 2 != 0)
            {
                result.Add(num);
            }
        }
        if (command == "first")
        {
            result = result.Take(count).ToList();
        }
        else
        {
            result = result.Skip(result.Count - count).ToList();
        }

        PrintArray(result);
    }

    private static void PrintArray(List<int> arr)
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }
}
