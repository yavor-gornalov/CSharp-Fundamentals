using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        var nameRegex = new Regex(@"[A-Za-z]");
        var distanceRegex = new Regex(@"\d");

        var drivers = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(d => new { Name = d, Score = 0 })
            .ToDictionary(d => d.Name, d => d.Score);

        while (true)
        {
            var line = Console.ReadLine();

            if (line == "end of race")
            {
                string[] places = { "1st", "2nd", "3rd" };
                int idx = 0;
                foreach (var driver in drivers.OrderByDescending(d => d.Value).Take(3))
                {
                    Console.WriteLine($"{places[idx++]} place: {driver.Key}");
                }
                break;
            }

            var currentDriver = string.Empty;
            var currentDistance = 0;
            foreach (var letter in nameRegex.Matches(line))
            {
                currentDriver += letter;
            }

            foreach (var digit in distanceRegex.Matches(line))
            {
                currentDistance += int.Parse(digit.ToString());
            }

            if (drivers.ContainsKey(currentDriver))
            {
                drivers[currentDriver] += currentDistance;
            }
        }
    }
}
