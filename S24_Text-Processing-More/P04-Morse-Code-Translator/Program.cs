using System.Text;

internal class Program
{
    static void Main()
    {
        Dictionary<string, char> morseToAlpha = new Dictionary<string, char>()
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
            {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
            {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
            {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
            {"--..", 'Z'}
        };

        string[] words = Console.ReadLine().Split(" | ").ToArray();

        StringBuilder decodedMessage = new StringBuilder();

        foreach (var word in words)
        {
            foreach (var letter in word.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                decodedMessage.Append(morseToAlpha[letter]);
            }
            decodedMessage.Append(" ");
        }
        Console.WriteLine(decodedMessage.ToString());
    }
}
