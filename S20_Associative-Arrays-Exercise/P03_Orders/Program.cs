internal class Program
{
    static void Main()
    {
        // { product: [ price, quantity ] }
        Dictionary<string, double[]> products = new Dictionary<string, double[]>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "buy")
            {
                PrintProducts(products);
                break;
            }

            string[] tokens = line.Split().ToArray();

            string product = tokens[0];
            double price = double.Parse(tokens[1]);
            double quantity = double.Parse(tokens[2]);

            if (!products.ContainsKey(product))
            {
                products.Add(product, new double[] { price, quantity });
                continue;
            }

            products[product][0] = price;
            products[product][1] += quantity;
        }


    }
    public static void PrintProducts(Dictionary<string, double[]> products)
    {
        foreach (var item in products)
        {
            double price = item.Value[0];
            double quantity = item.Value[1];
            Console.WriteLine($"{item.Key} -> {price * quantity:F2}");
        }
    }
}
