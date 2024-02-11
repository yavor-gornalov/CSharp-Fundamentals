internal class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        string userName = Console.ReadLine();
        while (true)
        {
            string userPass = string.Join("", Console.ReadLine().ToArray().Reverse());
            if (userName == userPass)
            {
                Console.WriteLine($"User {userName} logged in.");
                break;
            }

            if (attempts >= 3)
            {
                Console.WriteLine($"User {userName} blocked!");
                break;
            }

            Console.WriteLine("Incorrect password. Try again.");
            attempts++;
        }
    }
}