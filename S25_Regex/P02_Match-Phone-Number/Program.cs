using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        var pattern = @"\+359( |\-)2(\1)\d{3}(\1)\d{4}\b";
        var numbers = Console.ReadLine();
        var phoneMatches = Regex.Matches(numbers, pattern);

        var phones = phoneMatches
            .Cast<Match>()
            .Select(p => p.Value.Trim())
            .ToList();

        Console.WriteLine(string.Join(", ", phones));
    }
}
