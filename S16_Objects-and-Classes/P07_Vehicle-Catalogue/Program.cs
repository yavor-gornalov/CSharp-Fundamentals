
using System.Reflection;

internal class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end")
            {
                catalog.PrintAllData();
                break;
            }

            string[] tokens = line.Split("/").ToArray();

            string vehicleType = tokens[0];
            string brand = tokens[1];
            string model = tokens[2];
            int value = int.Parse(tokens[3]);

            if (vehicleType == "Car")
            {
                catalog.AddCar(brand, model, value);
            }
            else if (vehicleType == "Truck")
            {
                catalog.AddTruck(brand, model, value);
            }

        }
    }



}

public class Catalog
{
    List<Car> Cars;
    List<Truck> Trucks;

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public void AddCar(string brand, string model, int horsePower) => Cars.Add(new Car(brand, model, horsePower));

    public void AddTruck(string brand, string model, int weight) => Trucks.Add(new Truck(brand, model, weight));

    public void PrintCars()
    {
        if (Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (Vehicle vehicle in Cars.OrderBy(x => x.Brand)) vehicle.PrintInfo();
        }
    }
    public void PrintTrucks()
    {
        if (Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            foreach (Vehicle vehicle in Trucks.OrderBy(x => x.Brand)) vehicle.PrintInfo();
        }
    }

    public void PrintAllData()
    {
        PrintCars();
        PrintTrucks();
    }
}
public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public abstract void PrintInfo();
}

public class Truck : Vehicle
{
    public int Weight { get; set; }

    public Truck(string brand, string model, int weight) : base(brand, model)
    {
        Weight = weight;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"{Brand}: {Model} - {Weight}kg");
    }
}

public class Car : Vehicle
{
    public int HorsePower { get; set; }

    public Car(string brand, string model, int horsePower) : base(brand, model)
    {
        HorsePower = horsePower;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"{Brand}: {Model} - {HorsePower}hp");
    }
}