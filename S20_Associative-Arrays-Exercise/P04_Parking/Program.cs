internal class Program
{
    static void Main()
    {
        Dictionary<string, string> parkingLot = new Dictionary<string, string>();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();

            string command = tokens[0];

            if (command == "register")
            {
                string user = tokens[1];
                string plate = tokens[2];

                if (parkingLot.ContainsKey(user))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {plate}");
                }
                else
                {
                    parkingLot[user] = plate;
                    Console.WriteLine($"{user} registered {plate} successfully");
                }
            }
            else if (command == "unregister")
            {
                string user = tokens[1];
                if (!parkingLot.ContainsKey(user))
                {
                    Console.WriteLine($"ERROR: user {user} not found");
                }
                else
                {
                    parkingLot.Remove(user);
                    Console.WriteLine($"{user} unregistered successfully");
                }
            }
        }
        foreach (var pair in parkingLot)
        {
            Console.WriteLine($"{pair.Key} => {pair.Value}");
        }
    }
}
