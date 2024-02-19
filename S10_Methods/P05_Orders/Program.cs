
internal class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine($"{GetTotal(product, quantity):F2}");
    }

    private static object GetTotal(string? product, int quantity)
    {
        Dictionary<string, double> productPrices = new Dictionary<string, double>
        {
            { "coffee", 1.50 },
            { "water", 1.00 },
            { "coke", 1.40 },
            { "snacks", 2.00 }
        };

        return quantity * productPrices[product];
    }
}
