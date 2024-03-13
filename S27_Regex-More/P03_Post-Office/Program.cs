using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string line = Console.ReadLine();

        string[] tokens = line.Split("|", StringSplitOptions.RemoveEmptyEntries);

        string capitalLettersPattern = @"([\#\$\%\*\&])(?<letters>[A-Z]+)(\1)";

        Dictionary<char, int> capitalLetters = Regex
            .Match(tokens[0], capitalLettersPattern)
            .Groups["letters"].Value
            .ToDictionary(x => x, x => 0);

        List<int> wordLengths = new List<int>();
        foreach (char c in capitalLetters.Keys)
        {
            string lengthPattern = $"{(int)c}:(?<length>0\\d|\\d{{2}})";
            var match = Regex.Match(tokens[1], lengthPattern);
            int length;
            if (match.Success)
            {
                var len = match.Groups["length"].Value;
                if (int.TryParse(len, out length)) capitalLetters[c] = length;
            }

        }

        foreach ((var key, var value) in capitalLetters)
        {
            //string wordPattern = $"(^|\\s)(?<word>{key}[a-zA-Z\\-]{{{value}}})\\b";
            string wordPattern = $@"(?<=\s|^)(?<word>{key}[\S]{{{value}}})(?=\s|$)";
            string word = Regex.Match(tokens[2], wordPattern).Groups["word"].Value;
            Console.WriteLine(word);
        }
    }
}
