

internal class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        int N = int.Parse(Console.ReadLine());

        CarsConstructor(cars, N);

        Competition(cars);

        PrintCompetonResults(cars);

    }

    private static void CarsConstructor(List<Car> cars, int N)
    {
        for (int i = 0; i < N; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split()
                .ToArray();

            string model = tokens[0];
            double fuelAmount = double.Parse(tokens[1]);
            double fuelConsumtion = double.Parse(tokens[2]);
            Car carToAppend = new Car(model, fuelAmount, fuelConsumtion);
            cars.Add(carToAppend);
        }
    }

    private static void Competition(List<Car> cars)
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End") break;

            string[] tokens = line
                .Split()
                .ToArray();

            string command = tokens[0];
            string model = tokens[1];
            double distance = double.Parse(tokens[2]);

            if (command != "Drive") continue;

            Car currentCar = GetCarByModel(cars, model);

            if (currentCar == null) continue;

            currentCar.Drive(distance);
        }
    }

    private static void PrintCompetonResults(List<Car> cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    private static Car? GetCarByModel(List<Car> cars, string model)
        => cars.FirstOrDefault(c => c.Model == model);


}

public class Car
{
    public double traveledDistance;



    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.traveledDistance = 0;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; set; }

    public double TraveledDistance
        => this.traveledDistance;

    public override string ToString()
        => $"{Model} {FuelAmount:F2} {TraveledDistance}";

    public void Drive(double distance)
    {
        double fuelNeeded = distance * this.FuelConsumption;
        if (fuelNeeded > this.FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmount -= fuelNeeded;
            this.traveledDistance += distance;
        }
    }

}