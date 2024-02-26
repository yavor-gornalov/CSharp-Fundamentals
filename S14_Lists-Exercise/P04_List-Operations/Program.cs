internal class Program
{
    static void Main()
    {
        Dictionary<string, Action<List<int>, string[]>> mapper = new()
        {
            { "Add", AddNumber },
            { "Insert", InserNumberAtIndex },
            { "Remove", RemoveNumberAtIndex },
            { "Shift", ShiftArray },
        };

        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "End")
            {
                Console.WriteLine(string.Join(" ", numbers));
                break;
            }

            string[] tokens = line.Split().ToArray();
            string command = tokens[0];

            mapper[command](numbers, tokens.Skip(1).ToArray());
        }

    }


    static void AddNumber(List<int> arr, string[] tokens)
    {
        int number = int.Parse(tokens[0]);
        arr.Add(number);
    }

    static void InserNumberAtIndex(List<int> arr, string[] tokens)
    {
        int number = int.Parse(tokens[0]);
        int index = int.Parse(tokens[1]);

        if (!IsIndexValid(arr, index)) return;

        arr.Insert(index, number);
    }

    static void RemoveNumberAtIndex(List<int> arr, string[] tokens)
    {
        int index = int.Parse(tokens[0]);

        if (!IsIndexValid(arr, index)) return;

        arr.RemoveAt(index);
    }

    static void ShiftArray(List<int> arr, string[] tokens)
    {
        string direction = tokens[0];
        int count = int.Parse(tokens[1]);

        for (int i = 0; i < count; i++)
        {

            if (direction == "left")
            {
                int first = arr.First();
                arr.Remove(first);
                arr.Add(first);
            }
            else
            {
                int last = arr.Last();
                arr.RemoveAt(arr.Count - 1);
                arr.Insert(0, last);
            }
        }
    }

    static bool IsIndexValid(List<int> arr, int idx)
    {
        if (idx < 0 || idx >= arr.Count)
        {
            Console.WriteLine("Invalid index");
            return false;
        }
        return true;
    }
}
