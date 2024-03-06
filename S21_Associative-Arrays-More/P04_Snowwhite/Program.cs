class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Once upon a time") break;

            string[] tokens = line.Split(" <:> ");
            string name = tokens[0];
            string color = tokens[1];
            int physics = int.Parse(tokens[2]);

            if (!dwarfs.ContainsKey(color))
            {
                dwarfs[color] = new Dictionary<string, int>();
            }
            if (!dwarfs[color].ContainsKey(name))
            {
                dwarfs[color][name] = physics;
            }
            else
            {
                dwarfs[color][name] = Math.Max(dwarfs[color][name], physics);
            }
        }

        var dwarfsInfo = dwarfs.SelectMany(color => color.Value.Select(dwarf => new
        {
            Dwarf = $"{color.Key}:{dwarf.Key}",
            Info = new
            {
                Height = dwarf.Value,
                Count = color.Value.Count
            }
        })).ToDictionary(d => d.Dwarf, d => d.Info);

        foreach (var dwarf in dwarfsInfo.OrderByDescending(x => x.Value.Height).ThenByDescending(x => x.Value.Count))
        {
            string[] dwarfTokens = dwarf.Key.Split(":");
            string color = dwarfTokens[0];
            string name = dwarfTokens[1];
            int height = dwarf.Value.Height;
            Console.WriteLine($"({color}) {name} <-> {height}");
        }
    }
}