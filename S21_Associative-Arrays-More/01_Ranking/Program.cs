using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

internal class Program
{
    static void Main()
    {
        // { contest: password }
        Dictionary<string, string> contestPasswords = new Dictionary<string, string>();

        // { contest: {user: points} }
        Dictionary<string, Dictionary<string, double>> contestResults = new Dictionary<string, Dictionary<string, double>>();


        ConstructContestPasswords(contestPasswords, contestResults);

        ExecuteSubmissions(contestPasswords, contestResults);
        PrintFinalResults(contestResults);
    }

    private static void PrintFinalResults(Dictionary<string, Dictionary<string, double>> contestResults)
    {
        Dictionary<string, Dictionary<string, double>> userPoints = new Dictionary<string, Dictionary<string, double>>();
        foreach (var userResult in contestResults)
        {
            string contest = userResult.Key;
            foreach (var pair in userResult.Value)
            {
                string username = pair.Key;
                double points = pair.Value;
                if (!userPoints.ContainsKey(username))
                {
                    userPoints.Add(username, new Dictionary<string, double>());
                }
                userPoints[username].Add(contest, points);
            }
        }

        Dictionary<string, double> candidates = new Dictionary<string, double>();
        List<string> results = new List<string> { "Ranking:" };

        foreach (var userResult in userPoints.OrderBy(x => x.Key))
        {
            string username = userResult.Key;
            results.Add(username);
            if (!candidates.ContainsKey(username))
            {
                candidates.Add(username, 0);
            }
            foreach (var pair in userResult.Value.OrderByDescending(x => x.Value))
            {
                string contest = pair.Key;
                double points = pair.Value;
                results.Add($"#  {contest} -> {points}");
                candidates[username] += points;
            }
        }
        (string name, double score) = candidates.OrderByDescending(x => x.Value).First();
        Console.WriteLine($"Best candidate is {name} with total {score} points.");
        Console.WriteLine(string.Join("\n", results));
    }

    private static void ExecuteSubmissions(Dictionary<string, string> contestPasswords,
        Dictionary<string, Dictionary<string, double>> contestResults)
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end of submissions") break;

            //{contest}=>{password}=>{username}=>{points}"
            string[] tokens = line.Split("=>").ToArray();

            string contest = tokens[0];
            string password = tokens[1];
            string username = tokens[2];
            double points = double.Parse(tokens[3]);

            if (!contestPasswords.ContainsKey(contest)) continue;

            if (contestPasswords[contest] != password) continue;

            if (!contestResults[contest].ContainsKey(username))
            {
                contestResults[contest].Add(username, points);
            }
            contestResults[contest][username] = Math.Max(points, contestResults[contest][username]);
        }
    }

    private static void ConstructContestPasswords(Dictionary<string, string> contestPasswords,
        Dictionary<string, Dictionary<string, double>> contestResults)
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end of contests") break;

            string[] tokens = line.Split(":").ToArray();

            string contest = tokens[0];
            string password = tokens[1];

            if (!contestPasswords.ContainsKey(contest))
            {
                contestPasswords.Add(contest, password);
                contestResults.Add(contest, new Dictionary<string, double>());
            }
        }
    }
}
