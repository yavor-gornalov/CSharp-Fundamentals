internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToList();

        Dictionary<string, Action<int[]>> mapper = new() {
            { "Add" , (x) => nums.Add(x[0]) },
            { "Remove", (x) => nums.Remove(x[0]) },
            { "RemoveAt", (x) => nums.RemoveAt(x[0]) },
            {  "Insert", (x) => nums.Insert(x[1], x[0]) }
        };

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            string[] tokens = line.Split().ToArray();
            string command = tokens[0];
            int[] args = tokens.Skip(1)
                .Select(x => int.Parse(x))
                .ToArray();
            mapper[command](args);
        }
    }
}
