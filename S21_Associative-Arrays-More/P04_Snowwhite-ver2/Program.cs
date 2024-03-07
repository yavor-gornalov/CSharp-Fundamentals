internal class Program
{
    static void Main()
    {
        // { color: { name: physics } }
        Dictionary<string, int> dwarfs = new Dictionary<string, int>();

        // { color: count }
        Dictionary<string, int> colorsCount = new Dictionary<string, int>();
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Once upon a time")
            {
                foreach ((var dwarfColorName, var dwarfPhysycs) in dwarfs.OrderByDescending(d => d.Value).ThenByDescending(d => colorsCount[d.Key.Split(":")[0]]))
                {
                    string[] colorName = dwarfColorName.Split(':');
                    string dwarfColor = colorName[0];
                    string dwarfName = colorName[1];
                    Console.WriteLine($"({dwarfColor}) {dwarfName} <-> {dwarfPhysycs}");
                }

                break;
            }

            string[] tokens = line.Split(" <:> ").ToArray();

            string name = tokens[0];
            string color = tokens[1];
            int physics = int.Parse(tokens[2]);

            string dwarfKey = $"{color}:{name}";

            if (!dwarfs.ContainsKey(dwarfKey))
            {
                dwarfs.Add(dwarfKey, 0);
                if (!colorsCount.ContainsKey(color))
                {
                    colorsCount.Add(color, 0);
                }
                colorsCount[color]++;
            }

            dwarfs[dwarfKey] = Math.Max(physics, dwarfs[dwarfKey]);

        }
    }
}
