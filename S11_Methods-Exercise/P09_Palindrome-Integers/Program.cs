
internal class Program
{
    static void Main()
    {
        while (true)
        {
            string integer = Console.ReadLine();

            if (integer == "END") break;

            Console.WriteLine(IsPalindrome(integer));
        }

    }

    private static string IsPalindrome(string integer)
    {
        int len = integer.Length;
        for (int i = 0; i <= len / 2; i++)
        {
            if (integer[i] != integer[len - i - 1])
            {
                return "false";
            }
        }
        return "true";
    }
}
