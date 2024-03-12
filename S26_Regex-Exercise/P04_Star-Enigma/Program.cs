using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        var pattern = @"[^\@\-\!\:\>]*\@(?<planetName>[A-Z][a-z]+)*[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<attackType>[A|D]{1})\![^\@\-\!\:\>]*\-\>(?<soldierCount>\d+)[^\@\-\!\:\>]*";
        var re = new Regex(pattern);

        char[] secretLetters = { 's', 't', 'a', 'r' };

        int N = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> planets = new()
        {
            {"Attacked", new List<string> () },
            {"Destroyed", new List<string> ()}
        };

        for (int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();

            int key = line.Select(l => secretLetters.Contains(char.ToLower(l)) ? 1 : 0).ToArray().Sum();

            var secretMessage = new StringBuilder(secretLetters.Length);

            foreach (char letter in line)
            {
                secretMessage.Append((char)(letter - key));
            }

            Match match = re.Match(secretMessage.ToString());

            if (match.Success)
            {
                string planetName = match.Groups["planetName"].Value;
                int population = int.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["attackType"].Value == "A" ? "Attacked" : "Destroyed";
                int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                planets[attackType].Add(planetName);
            }
        }

        PrintPlanet(planets, "Attacked");
        PrintPlanet(planets, "Destroyed");

    }

    private static void PrintPlanet(Dictionary<string, List<string>> planets, string attackType)
    {
        var result = new StringBuilder();
        result.AppendLine($"{attackType} planets: {planets[attackType].Count()}");
        foreach (var planet in planets[attackType].OrderBy(x => x)) result.AppendLine($"-> {planet}");
        Console.Write(result.ToString());
    }
}
