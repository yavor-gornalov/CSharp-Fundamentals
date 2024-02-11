using System.Reflection;

internal class Program
{
    static void Main()
    {
        Dictionary<string, double> availableGames = new() {
            {"OutFall 4", 39.99},
            {"CS: OG", 15.99 },
            {"Zplinter Zell", 19.99},
            {"Honored 2", 59.99 },
            {"RoverWatch", 29.99 },
            {"RoverWatch Origins Edition", 39.99 }
        };
        double balance = double.Parse(Console.ReadLine());
        double totalSpent = 0;
        while (true)
        {
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }
            string game = Console.ReadLine();
            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
                break;
            };
            if (!availableGames.ContainsKey(game))
            {
                Console.WriteLine("Not Found");
                continue;
            }
            if (balance < availableGames[game])
            {
                Console.WriteLine("Too Expensive");
                continue;
            }
            balance -= availableGames[game];
            totalSpent += availableGames[game];
            Console.WriteLine($"Bought {game}");
        }
    }
}
