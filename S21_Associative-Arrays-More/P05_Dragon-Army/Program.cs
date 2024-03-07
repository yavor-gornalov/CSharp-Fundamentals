using System.Xml.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double[]>> dragons = new Dictionary<string, Dictionary<string, double[]>>();

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            // "{type} {name} {damage} {health} {armor}"
            List<string> tokens = Console.ReadLine()
                .Split()
                .ToList();

            string type = tokens[0];

            string name = tokens[1];

            double damage = 45;
            if (tokens[2] != "null") double.TryParse(tokens[2], out damage);

            double health = 250;
            if (tokens[3] != "null") double.TryParse(tokens[3], out health);

            double armor = 10;
            if (tokens[4] != "null") double.TryParse(tokens[4], out armor);

            if (!dragons.ContainsKey(type))
            {
                dragons.Add(type, new Dictionary<string, double[]>());
            }

            if (!dragons[type].ContainsKey(name))
            {
                dragons[type].Add(name, new double[3]);
            }

            dragons[type][name][0] = damage;
            dragons[type][name][1] = health;
            dragons[type][name][2] = armor;
        }
        foreach ((var dragonType, var dragonData) in dragons)
        {
            double avgDamage = dragonData.Values.Select(d => d[0]).Average();
            double avgHealth = dragonData.Values.Select(d => d[1]).Average();
            double avgArmor = dragonData.Values.Select(d => d[2]).Average();

            Console.WriteLine($"{dragonType}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");
            foreach ((var dragonName, var data) in dragonData.OrderBy(d => d.Key))
            {
                Console.WriteLine($"-{dragonName} -> damage: {data[0]}, health: {data[1]}, armor: {data[2]}");
            }
        }
    }
}
