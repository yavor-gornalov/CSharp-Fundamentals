using System.Text;

internal class Program
{
    static void Main()
    {
        StringBuilder output = new StringBuilder();
        while (true) { 
            string word = Console.ReadLine();

            if ( word == "end")
            {
                Console.WriteLine(output);
                break;
            }
            output.Append($"{word} = ");
            char[] letters = word.ToCharArray();
            foreach (char c in letters.Reverse())
            {
                output.Append(c);
            }
            output.Append('\n');
        }
    }
}
