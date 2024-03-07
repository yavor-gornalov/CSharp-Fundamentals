internal class Program
{
    static void Main()
    {
        string substring = Console.ReadLine();
        string mainString = Console.ReadLine();

        while (mainString.Contains(substring))
        {
            mainString = mainString.Replace(substring, "");
        }
        Console.WriteLine(mainString);
    }
}
