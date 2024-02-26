internal class Program
{
    static void Main()
    {
        List<int> arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        Dictionary<string, Action<int[]>> solver = new() {
            { "Insert" , (x) => arr.Insert(x[1], x[0]) },
            { "Delete", (x) => arr.Remove(x[0]) },
        };

        while (true)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string command = tokens[0];

            if (command == "end")
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            solver[command](tokens.Skip(1).Select(int.Parse).ToArray());
        }
    }
}
