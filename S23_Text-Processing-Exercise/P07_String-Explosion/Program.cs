using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string result = "";

        int strength = 0;
        int idx = 0;
        while (idx < text.Length)
        {
            char prevElement = text[idx++];
            if (prevElement == '>')
            {
                int startIdx = idx;
                while (idx < text.Length && char.IsDigit(text[idx]))
                {
                    idx++;
                    strength--;
                }
                strength += int.Parse(text.Substring(startIdx, idx - startIdx));
                result += prevElement;
            }
            else
            {
                if (strength == 0)
                {
                    result += prevElement;
                }
                else
                {
                    strength--;
                }
            }
        }

        Console.WriteLine(result);
    }
}
