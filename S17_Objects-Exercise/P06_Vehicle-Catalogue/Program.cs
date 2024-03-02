
internal class Program
{
    static void Main()
    {
        Catalogue myCatalogue = new Catalogue();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End") break;

            string[] tokens = line
                .Split()
                .ToArray();

            string typeOfVehicle = tokens[0];
            string model = tokens[1];
            string color = tokens[2];
            int horsePower = int.Parse(tokens[3]);

            Vehicle newVehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
            myCatalogue.AddVehicle(newVehicle);
        }

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Close the Catalogue")
            {
                Console.WriteLine($"Cars have average horsepower of: {myCatalogue.GetAverageHP("car"):F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {myCatalogue.GetAverageHP("truck"):F2}.");
                break;
            }

            Vehicle vehicleToPrint = myCatalogue.GetVehicle(line);
            if (vehicleToPrint != null)
            {
                Console.WriteLine(vehicleToPrint.ToString());
            }

        }
    }
}

public class Vehicle
{
    public Vehicle(string typeOvVehicle, string model, string color, int horsePower)
    {
        TypeOfVehicle = typeOvVehicle;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string TypeOfVehicle { get; private set; }
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int HorsePower { get; private set; }

    public override string ToString()
    {
        string captalizedType = TypeOfVehicle.Replace(TypeOfVehicle[0], char.ToUpper(TypeOfVehicle[0]));
        string result = $"Type: {captalizedType}\n"
                        + $"Model: {Model}\n"
                        + $"Color: {Color}\n"
                        + $"Horsepower: {HorsePower}";
        return result;
    }
}

public class Catalogue
{
    private readonly List<Vehicle> vehicles;

    public Catalogue()
    {
        vehicles = new List<Vehicle>();
    }
    public List<Vehicle> Vehicles
        => this.vehicles;

    public void AddVehicle(Vehicle vehicle)
        => this.vehicles.Add(vehicle);

    public Vehicle GetVehicle(string model)
        => this.vehicles.FirstOrDefault(v => v.Model == model);

    public double GetAverageHP(string type)
    {
        List<Vehicle> vehiclesOfType = vehicles.Where(v => v.TypeOfVehicle == type).ToList();

        int countOfVehicles = vehiclesOfType.Count;
        if (countOfVehicles == 0) return 0;

        int totalHorsePower = vehiclesOfType.Sum(v => v.HorsePower);
        double average = (double)totalHorsePower / countOfVehicles;

        return average;
    }
}