using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        string emailPattern = @"\s(?<email>[a-zA-Z0-9]+([-._][a-zA-Z0-9]+)*@[a-zA-Z]+([-][a-zA-Z]+)*(\.[a-zA-Z]+([-][a-zA-Z]+)*)+)\b";
        var re = new Regex(emailPattern);

        MatchCollection matches = re.Matches(line);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["email"].Value);
        }
    }
}
