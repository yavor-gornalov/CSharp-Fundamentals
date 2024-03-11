using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
        Regex re = new Regex(pattern, RegexOptions.Multiline);

        string line = Console.ReadLine();

        MatchCollection matches = re.Matches(line);

        StringBuilder names = new StringBuilder();
        foreach (Match match in matches)
        {
            names.Append(match.Groups[1] + " ");
        }

        Console.WriteLine(names.ToString());
    }
}
