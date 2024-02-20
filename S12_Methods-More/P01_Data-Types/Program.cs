internal class Program
{
    static void Main()
    {
        string inputType = Console.ReadLine();
        switch (inputType)
        {
            case "int": Console.WriteLine(int.Parse(Console.ReadLine()) * 2); break;
            case "real": Console.WriteLine($"{double.Parse(Console.ReadLine()) * 1.5:F2}"); break;
            case "string": Console.WriteLine('$' + Console.ReadLine() + '$'); break;
        }
    }
}
