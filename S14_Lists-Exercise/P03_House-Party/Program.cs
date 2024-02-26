internal class Program
{
    static void Main()
    {
        List<string> guestsList = new List<string>();
        int numberOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCommands; i++)
        {

            List<string> tokens = Console.ReadLine().Split().ToList();
            string guest = tokens[0];
            bool isLeaving = tokens.Contains("not");

            if (isLeaving)
            {
                if (!guestsList.Contains(guest))
                {
                    Console.WriteLine($"{guest} is not in the list!");
                    continue;
                }
                guestsList.Remove(guest);

            }
            else
            {
                if (guestsList.Contains(guest))
                {
                    Console.WriteLine($"{guest} is already in the list!");
                    continue;
                }
                guestsList.Add(guest);
            }
        }
        foreach (string guest in guestsList)
        {
            Console.WriteLine(guest);
        }
    }
}
