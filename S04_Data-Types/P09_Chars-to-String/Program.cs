public class Program
{
    public static void Main()
    {
        List<char> symbolList = new();
        for (int i = 0; i < 3; i++)
        {
            symbolList.Add(char.Parse(Console.ReadLine()));
        }
        Console.WriteLine(string.Join("", symbolList));
    }
}