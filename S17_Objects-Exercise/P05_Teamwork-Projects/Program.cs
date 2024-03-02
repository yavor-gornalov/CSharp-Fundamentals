internal class Program
{
    static void Main()
    {
        List<Team> teams = new List<Team>();
        List<string> users = new List<string>();
        int numberOfTeams = int.Parse(Console.ReadLine());

        TeamsConstructor(teams, users, numberOfTeams);

        TeamsAassignment(teams, users);

        PrintTeamsInfo(teams);
    }

    private static void TeamsConstructor(List<Team> teams, List<string> users, int numberOfTeams)
    {
        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] tokens = Console.ReadLine().Split("-").ToArray();
            string creator = tokens[0];
            string teamName = tokens[1];

            if (GetTeamByName(teams, teamName) != null)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (GetTeamByCreator(teams, creator) != null)
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            Team newTeam = new Team(teamName, creator);

            teams.Add(newTeam);
            users.Add(creator);

            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }
    }

    private static void TeamsAassignment(List<Team> teams, List<string> users)
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end of assignment")
            {
                return;
            }

            string[] tokens = line.Split("->");

            string user = tokens[0];
            string teamName = tokens[1];

            Team team = GetTeamByName(teams, teamName);
            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (users.Contains(user))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            team.AddUser(user);
            users.Add(user);
        }
    }

    private static void PrintTeamsInfo(List<Team> teams)
    {
        foreach (Team team in teams
            .Where(x => x.Users.Count > 0)
            .OrderByDescending(x => x.Users.Count)
            .ThenBy(x => x.TeamName))
        {
            Console.WriteLine(team.ToString());
        }

        Console.WriteLine("Teams to disband:");
        foreach (Team team in teams
            .Where(x => x.Users.Count == 0)
            .OrderBy(x => x.TeamName))
        {
            Console.WriteLine(team.ToString());
        }
    }

    public static Team? GetTeamByName(List<Team> teams, string teamName)
    {
        return teams.Where(x => x.TeamName == teamName).FirstOrDefault();
    }

    public static Team? GetTeamByCreator(List<Team> teams, string creator)
    {
        return teams.Where(x => x.Creator == creator).FirstOrDefault();
    }
}



public class Team
{
    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Users { get; set; }

    public Team(string teamName, string creator)
    {
        TeamName = teamName;
        Creator = creator;
        Users = new List<string>();
    }

    public void AddUser(string user)
    {
        if (Users.Contains(user))
        {
            Console.WriteLine($"Member {user} cannot join team {TeamName}!");
            return;
        }
        Users.Add(user);
    }

    public override string ToString()
    {
        if (Users.Count == 0)
        {
            return TeamName;
        }

        List<string> result = new List<string>() {
        TeamName, $"- {Creator}",};

        Users.Sort();
        foreach (var user in Users)
        {
            result.Add($"-- {user}");
        }

        return string.Join("\n", result);

    }
}
