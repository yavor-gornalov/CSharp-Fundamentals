internal class Program
{
    static void Main()
    {
        char[] dashes = new char[] { '-', '_' };
        string[] usernames = Console.ReadLine()
            .Split(", ")
            .ToArray();

        foreach (string user in usernames)
        {
            if (user.Length < 3 || user.Length > 16) continue;

            bool isValid = true;
            foreach (char symbol in user.ToCharArray())
            {
                if (!char.IsLetterOrDigit(symbol) && !dashes.Contains(symbol))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid) Console.WriteLine(user);
        }

    }
}
