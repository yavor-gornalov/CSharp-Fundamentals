internal class Program
{
    static void Main()
    {
        string line = Console.ReadLine();

        string digits = string.Empty;
        string letters = string.Empty;
        string symbols = string.Empty;

        foreach (char symbol in line.ToCharArray())
        {
            if (char.IsDigit(symbol))
            {
                digits += symbol - '0';
            }
            else if (char.IsLetter(symbol))
            {
                letters += symbol;
            }
            else
            {
                symbols += symbol;
            }
        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(symbols);
    }
}
