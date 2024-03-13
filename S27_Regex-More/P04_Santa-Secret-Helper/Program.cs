using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        var pattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*!(?<behavior>[G|N])!";
        var re = new Regex(pattern);

        var sb = new StringBuilder();

        int key = int.Parse(Console.ReadLine());

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end") break;

            string message = string.Join("", line.Select(x => (char)(x - key)).ToArray());

            Match match = re.Match(message);

            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                string behavior = match.Groups["behavior"].Value;

                if (behavior == "G") sb.AppendLine(name);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
