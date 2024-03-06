using Microsoft.VisualBasic;
using System.Numerics;

internal class Program
{
    static void Main()
    {
        // { player: {position: skill} }
        Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Season end")
            {
                PrintStats(playerPool);
                break;
            }

            if (line.Contains(" -> "))
            {
                AddPlayer(playerPool, line);

            }
            else if (line.Contains(" vs "))
            {
                Duel(playerPool, line);
            }
        }
    }

    private static void PrintStats(Dictionary<string, Dictionary<string, int>> playerPool)
    {
        List<string> result = new List<string>();
        foreach ((var player, var skills) in playerPool.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
        {
            int totalSkill = skills.Values.Sum();
            result.Add($"{player}: {totalSkill} skill");

            foreach ((var position, var skill) in skills.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                result.Add($"- {position} <::> {skill}");
            }
        }
        Console.WriteLine(string.Join("\n", result));
    }

    private static void Duel(Dictionary<string, Dictionary<string, int>> playerPool, string line)
    {
        string[] tokens = line.Split(" vs ");

        string firstPlayerName = tokens[0];
        string secondPlayerName = tokens[1];

        if (!playerPool.ContainsKey(firstPlayerName)) return;
        if (!playerPool.ContainsKey(secondPlayerName)) return;

        if (!AtLeastOneSkillMatched(playerPool, firstPlayerName, secondPlayerName)) return;

        int firstPlayerTotalPoints = GetFirstPlayerTotalPoints(playerPool, firstPlayerName);
        int secondPlayerTotalPoints = GetFirstPlayerTotalPoints(playerPool, secondPlayerName);

        if (firstPlayerTotalPoints > secondPlayerTotalPoints)
        {
            playerPool.Remove(secondPlayerName);
        }
        else if (firstPlayerTotalPoints < secondPlayerTotalPoints)
        {
            playerPool.Remove(firstPlayerName);
        }
    }

    private static int GetFirstPlayerTotalPoints(Dictionary<string, Dictionary<string, int>> playerPool, string player)
    {
        int totalPoints = 0;
        foreach ((var position, var skill) in playerPool[player])
        {
            totalPoints += skill;
        }
        return totalPoints;
    }

    private static bool AtLeastOneSkillMatched(Dictionary<string, Dictionary<string, int>> playerPool, string firstPlayer, string secondPlayer)
    {
        bool hasMatch = playerPool[firstPlayer]
            .Select(x => x.Key)
            .Intersect(playerPool[secondPlayer].Keys)
            .Any();
        return hasMatch;
    }

    private static void AddPlayer(Dictionary<string, Dictionary<string, int>> playerPool, string line)
    {
        string[] tokens = line.Split(" -> ");

        string player = tokens[0];
        string position = tokens[1];
        int skill = int.Parse(tokens[2]);

        if (!playerPool.ContainsKey(player))
        {
            playerPool.Add(player, new Dictionary<string, int>());
        }
        if (!playerPool[player].ContainsKey(position))
        {
            playerPool[player].Add(position, 0);
        }
        playerPool[player][position] = Math.Max(skill, playerPool[player][position]);
    }
}
