internal class Program
{
    static void Main()
    {
        string message = Console.ReadLine();
        foreach (char symbol in message)
        {
            Console.Write((char)(symbol + 3));
        }
    }
}
