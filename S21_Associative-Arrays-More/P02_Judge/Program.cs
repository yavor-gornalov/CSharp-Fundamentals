internal class Program
{
    static void Main()
    {
        // { contest: { user: points } }
        Dictionary<string, Dictionary<string, int>> contestResults = new Dictionary<string, Dictionary<string, int>>();

        // { user: totalPoints }
        Dictionary<string, int> individualStatistics = new Dictionary<string, int>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "no more time")
            {
                PrintContestResults(contestResults);
                individualStatistics = ConstructIndividualData(contestResults);
                PrintIdividualStatistics(individualStatistics);
                break;
            }

            //input: "{username} -> {contest} -> {points}"
            string[] tokens = line.Split(" -> ").ToArray();
            string username = tokens[0];
            string contest = tokens[1];
            int points = int.Parse(tokens[2]);

            ConstructContestData(contestResults, contest, username, points);
        }
    }

    private static void PrintContestResults(Dictionary<string, Dictionary<string, int>> results)
    {
        List<string> result = new List<string>();
        foreach ((var contest, var data) in results)
        {
            result.Add(($"{contest}: {data.Count} participants"));
            int idx = 0;
            foreach ((var name, var score) in data.OrderByDescending(d => d.Value).ThenBy(d => d.Key))
            {
                idx++;
                result.Add(($"{idx}. {name} <::> {score}"));
            }
        }
        Console.WriteLine(string.Join("\n", result));

    }

    private static void PrintIdividualStatistics(Dictionary<string, int> statistics)
    {
        List<string> result = new() { "Individual standings:" };
        int idx = 0;
        foreach ((var user, var score) in statistics.OrderByDescending(s => s.Value).ThenBy(u => u.Key))
        {
            idx++;
            result.Add($"{idx}. {user} -> {score}");
        }
        Console.WriteLine(string.Join("\n", result));
    }


    private static void ConstructContestData(Dictionary<string, Dictionary<string, int>> data, string primeKey, string secondaryKey, int score)
    {
        if (!data.ContainsKey(primeKey))
        {
            data.Add(primeKey, new Dictionary<string, int>());
        }

        if (!data[primeKey].ContainsKey(secondaryKey))
        {
            data[primeKey].Add(secondaryKey, score);
        }
        else
        {
            data[primeKey][secondaryKey] = Math.Max(score, data[primeKey][secondaryKey]);
        }
    }

    private static Dictionary<string, int> ConstructIndividualData(Dictionary<string, Dictionary<string, int>> data)
    {
        Dictionary<string, int> individualData = new Dictionary<string, int>();

        foreach ((var contest, var stats) in data)
        {
            foreach ((var user, var score) in stats)
            {
                if (!individualData.ContainsKey(user))
                {
                    individualData.Add(user, 0);
                }
                individualData[user] += score;
            }
        }
        return individualData;
    }
}
