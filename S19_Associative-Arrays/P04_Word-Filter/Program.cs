internal class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split().ToArray();

        foreach (var word in words)
        {
            Console.Write(word.Length % 2 == 0 ? $"{word}\n" : "");
        }
    }
}
