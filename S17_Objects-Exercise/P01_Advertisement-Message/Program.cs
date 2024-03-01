internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Advertisement adv = new Advertisement();

        for (int i = 0; i < n; i++)
        {
            adv.PrintRandomAdvertisement();
        }
    }
}

public class Advertisement
{
    public List<string> Phrases { get; set; }
    public List<string> Events { get; set; }
    public List<string> Authors { get; set; }

    public List<string> Cities { get; set; }

    public Advertisement()
    {
        Phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        Events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        Authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        Cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    }
    public void PrintRandomAdvertisement()
    {
        Random random = new Random();
        string phrase = Phrases[random.Next(0, Phrases.Count)];
        string evnt = Events[random.Next(0, Events.Count)];
        string author = Authors[random.Next(0, Authors.Count)];
        string city = Cities[random.Next(0, Cities.Count)];

        Console.WriteLine($"{phrase} {evnt} {author} – {city}.");
    }
}
