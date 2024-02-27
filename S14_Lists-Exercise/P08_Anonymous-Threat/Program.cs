using System.Linq;

internal class Program
{
    static void Main()
    {
        List<string> strArray = Console.ReadLine()
            .Split(" ")
            .Select(x => x.Trim())
            .ToList();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "3:1")
            {
                Console.WriteLine(string.Join(" ", strArray));
                break;
            }

            string[] tokens = line
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string command = tokens[0];
            int[] args = tokens.Skip(1).Select(int.Parse).ToArray();

            if (command == "merge")
            {
                Merge(strArray, args[0], args[1]);
            }
            else if (command == "divide")
            {
                Divide(strArray, args[0], args[1]);
            }
        }
    }

    static void Merge(List<string> arr, int startIndex, int endIndex)
    {
        startIndex = Math.Max(startIndex, 0);
        endIndex = Math.Min(endIndex, arr.Count - 1);
        int count = endIndex - startIndex + 1;

        if (count < 0) return;

        string newElement = string.Join("", arr.GetRange(startIndex, count));
        arr.RemoveRange(startIndex, count);
        arr.Insert(startIndex, newElement);
    }

    static void Divide(List<string> arr, int index, int parts)
    {
        string oldElement = arr[index];
        int partLength = oldElement.Length / parts;

        List<char> oldElementChars = arr[index].ToList();
        List<string> newElement = new List<string>();

        int counter = 0;
        while (counter < parts)
        {
            newElement.Add(string.Join("", oldElementChars.GetRange(0, partLength)));
            oldElementChars.RemoveRange(0, partLength);
            counter++;
        }

        newElement[^1] += string.Join("", oldElementChars.GetRange(0, oldElementChars.Count));

        arr.RemoveAt(index);
        arr.InsertRange(index, newElement);
    }
}
