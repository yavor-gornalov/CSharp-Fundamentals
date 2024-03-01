using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            {
                PrintBoxes(boxes);  
                break;
            }

            string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string serrialNumber = tokens[0];
            string itemName = tokens[1];
            int itemQuantity = int.Parse(tokens[2]);
            double itemPrice = double.Parse(tokens[3]);

            Item newItem = new Item(itemName, itemPrice);
            Box newBox = new Box(serrialNumber, newItem, itemQuantity);
            boxes.Add(newBox);
        }
    }

    public static void PrintBoxes(List<Box> boxes)
    {
        boxes.Sort((x, y) => y.BoxPrice.CompareTo(x.BoxPrice));
        foreach (Box box in boxes)
        {
            box.ShowBox();
        }
    }
}



public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
}


public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public double BoxPrice { get; set; }

    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        BoxPrice = item.Price * itemQuantity;
    }

    public void ShowBox()
    {
        Console.WriteLine($"{SerialNumber}\n-- {Item.Name} - ${Item.Price:F2}: {ItemQuantity}\n-- ${BoxPrice:F2}");
    }

}
