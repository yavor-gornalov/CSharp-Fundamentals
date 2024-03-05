internal class Program
{
    static void Main()
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "stop")
            {
                foreach (var pair in resources) Console
                        .WriteLine($"{pair.Key} -> {pair.Value}");
                break;
            }

            string key = line;
            int value = int.Parse(Console.ReadLine());

            if (!resources.ContainsKey(key))
            {
                resources.Add(key, 0);
            }

            resources[key] += value;
        }
    }
}
