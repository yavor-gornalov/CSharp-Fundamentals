internal class Program
{
    static void Main()
    {
        List<double> acceptedCoins = new() { 0.1, 0.2, 0.5, 1, 2 };
        Dictionary<string, double> productsAvailable = new()
        {
            { "Nuts", 2.0 },
            { "Water", 0.7 },
            { "Crisps", 1.5 },
            { "Soda", 0.8 },
            { "Coke", 1.0 }
        };

        double change = 0;
        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Start") break;

            double coin = double.Parse(command);

            if (!acceptedCoins.Contains(coin))
            {
                Console.WriteLine($"Cannot accept {coin}");
                continue;
            };

            change += coin;
        }

        while (true)
        {
            string product = Console.ReadLine();

            if (product == "End") break;

            if (!productsAvailable.ContainsKey(product))
            {
                Console.WriteLine("Invalid product");
                continue;
            }

            if (change - productsAvailable[product] < 0)
            {
                Console.WriteLine("Sorry, not enough money");
                continue;
            }

            Console.WriteLine($"Purchased {product.ToLower()}");
            change -= productsAvailable[product];
        };

        Console.WriteLine($"Change: {change:F2}");
    }

}
