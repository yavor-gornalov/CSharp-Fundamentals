internal class Program
{
    static void Main()
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] letters = Console.ReadLine().ToArray();

        int lettersCount = letters.Where(x => vowels.Contains(Char.ToLower(x))).Count();
        
        Console.WriteLine(lettersCount);
    }
}
