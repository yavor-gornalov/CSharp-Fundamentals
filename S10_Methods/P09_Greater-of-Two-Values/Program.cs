
internal class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        switch (type)
        {
            case "int":
                Console.WriteLine(GetMax(int.Parse(first), int.Parse(second)));
                break;
            case "char":
                Console.WriteLine(GetMax(char.Parse(first), char.Parse(second)));
                break;
            case "string":
                Console.WriteLine(GetMax(first, second));
                break;
        }

    }

    private static int GetMax(int first, int second)
    {
        return first > second ? first : second;
    }

    private static char GetMax(char first, char second)
    {
        return first > second ? first : (char)second;
    }

    private static string GetMax(string first, string second)
    {
        return (string.Compare(first, second) > 0) ? first : second;
    }
}
