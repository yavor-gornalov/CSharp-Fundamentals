using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string pattern = @"(?<string>([\D]+))(?<number>[\d]+)";
        var re = new Regex(pattern);

        string line = Console.ReadLine();

        var result = new StringBuilder();

        foreach (Match pair in re.Matches(line))
        {
            string symbols = pair.Groups["string"].Value;
            int number;
            if (!int.TryParse(pair.Groups["number"].Value, out number)) continue;


            result.Append(string.Concat(Enumerable.Repeat(symbols.ToUpper(), number)));

        }

        int uniques = result.ToString().Distinct().ToArray().Length;
        Console.WriteLine($"Unique symbols used: {uniques}");
        Console.WriteLine(result.ToString());
    }
}
