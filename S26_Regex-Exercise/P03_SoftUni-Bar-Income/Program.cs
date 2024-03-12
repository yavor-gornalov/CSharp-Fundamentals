using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
        var re = new Regex(pattern);

        double totalIncome = 0;
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end of shift")
            {
                Console.WriteLine($"Total income: {totalIncome:F2}");
                break;
            }

            var match = re.Match(line);

            if (match.Success)
            {
                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double customerBill = price * count;
                Console.WriteLine($"{customer}: {product} - {customerBill:F2}");
                totalIncome += customerBill;
            }
        }
    }
}
