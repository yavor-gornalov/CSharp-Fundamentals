using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        var demons = new SortedDictionary<string, (int, double)>();

        string[] demonNames = Console.ReadLine()
            .Split(",")
            .Select(d => d.Trim())
            .ToArray();

        string healthPattern = @"[^0-9+\-*\/\.]";
        string damagePattern = @"([-+]?[0-9]*\.[0-9]+|[0-9]+)|([-+]?[0-9]+)";


        var healtRegex = new Regex(healthPattern);
        var damageRegex = new Regex(damagePattern);


        foreach (var demonName in demonNames)
        {

            MatchCollection healtPoints = healtRegex.Matches(demonName);
            MatchCollection damagePoints = damageRegex.Matches(demonName);

            int health = 0;
            foreach (Match match in healtPoints)
            {
                char value;
                if (char.TryParse(match.Value, out value))
                {
                    health += value;
                }
            }

            double damage = 0;
            foreach (Match match in damagePoints)
            {
                double value;
                if (double.TryParse(match.Value, out value))
                {
                    damage += value;
                }
            }

            foreach (char symbol in demonName)
            {
                if (symbol == '*') damage *= 2;
                else if (symbol == '/') damage /= 2;
            }

            if (!demons.ContainsKey(demonName))
            {
                demons.Add(demonName, (health, damage));
            }

        }

        foreach ((var name, (var helth, var damage)) in demons)
        {
            Console.WriteLine($"{name} - {helth} health, {damage:F2} damage");
        }
    }
}
