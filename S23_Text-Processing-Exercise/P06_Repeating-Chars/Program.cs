internal class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string filteredText = text[0].ToString();
        for (int i = 1; i < text.Length; i++)
        {

            if (text[i] != text[i - 1])
            {
                filteredText += text[i];
            }
        }

        if (text[^1] != filteredText[^1])
        {
            filteredText += text[^1];
        }

        Console.WriteLine(filteredText);
    }
}
