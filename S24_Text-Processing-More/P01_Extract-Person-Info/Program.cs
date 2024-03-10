using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string sentence = Console.ReadLine();
            string name = string.Empty;
            string age = string.Empty;

            foreach (Match match in Regex.Matches(sentence, @"\@([A-Z][a-z]+)\|", RegexOptions.IgnoreCase))
                name = match.Groups[1].ToString();

            foreach (Match match in Regex.Matches(sentence, @"\#(\d+)\*", RegexOptions.IgnoreCase))
                age = match.Groups[1].ToString();

            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}
