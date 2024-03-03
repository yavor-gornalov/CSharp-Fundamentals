using System.Runtime.CompilerServices;

internal class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        CreatePeople(people);
        CreateProducts(products);
        Shopping(people, products);
        PrintResults(people);

    }

    private static void CreatePeople(List<Person> people)
    {
        foreach (string info in Console.ReadLine()
            .Split(";", StringSplitOptions.RemoveEmptyEntries)
            .ToArray())
        {
            string[] tokens = info.Split("=");
            string name = tokens[0];
            double money = double.Parse(tokens[1]);

            Person personToAppend = new Person(name, money);
            people.Add(personToAppend);
        }
    }

    private static void CreateProducts(List<Product> products)
    {
        foreach (string info in Console.ReadLine()
            .Split(";", StringSplitOptions.RemoveEmptyEntries)
            .ToArray())
        {
            string[] tokens = info.Split("=");
            string name = tokens[0];
            double cost = double.Parse(tokens[1]);

            Product productToAppend = new Product(name, cost);
            products.Add(productToAppend);
        }
    }

    private static void Shopping(List<Person> people, List<Product> products)
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }

            string[] tokens = line.Split().ToArray();

            string personName = tokens[0];
            string productName = tokens[1];

            Person currentPerson = people.First(x => x.Name == personName);
            Product currentProduct = products.First(x => x.Name == productName);

            currentPerson.BuyProduct(currentProduct);
        }
    }

    private static void PrintResults(List<Person> people)
    {
        foreach (Person person in people)
        {
            string result = $"{person.Name} - ";
            if (person.Bag.Count > 0)
            {
                result += string.Join(", ", person.Bag.Select(p => p.Name).ToArray());
            }
            else
            {
                result += "Nothing bought";
            }
            Console.WriteLine(result);
        }
    }

}
public class Product
{
    public Product(string name, double cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
    public string Name { get; set; }
    public double Cost { get; set; }
}

public class Person
{
    private List<Product> bag;

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.bag = new List<Product>();
    }

    public string Name { get; set; }
    public double Money { get; set; }

    public List<Product> Bag
        => this.bag;

    public void BuyProduct(Product product)
    {
        if (product.Cost > this.Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            this.bag.Add(product);
            this.Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
    }
}
