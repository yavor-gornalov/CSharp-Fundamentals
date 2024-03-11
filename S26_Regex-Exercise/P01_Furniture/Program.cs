using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        var patern = @">>(?<name>[A-Za-z]+)<<(?<price>([0-9]|[1-9][0-9]+)(\.[0-9]+)*)!(?<quantity>\d+)\b";
        var re = new Regex(patern);
        var result = new StringBuilder().AppendLine("Bought furniture:");

        double totalPrise = 0;
        while (true)
        {
            var line = Console.ReadLine();

            if (line == "Purchase")
            {
                result.AppendLine($"Total money spend: {totalPrise:F2}");
                Console.WriteLine(result.ToString());
                break;
            }

            var orders = re.Matches(line);

            foreach (Match order in orders)
            {
                var name = order.Groups["name"].ToString();
                var price = double.Parse(order.Groups["price"].ToString());
                var quantity = int.Parse(order.Groups["quantity"].ToString());

                totalPrise += price * quantity;
                result.AppendLine(name);
            }
        }
    }
}
