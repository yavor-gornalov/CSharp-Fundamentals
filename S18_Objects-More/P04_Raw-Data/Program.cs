internal class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split()
                .ToArray();

            //"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"
            string model = tokens[0];
            int speed = int.Parse(tokens[1]);
            int power = int.Parse(tokens[2]);
            int weight = int.Parse(tokens[3]);
            string type = tokens[4];

            Engine engine = new Engine(speed, power);
            Cargo cargo = new Cargo(weight, type);

            Car car = new Car(model, engine, cargo);

            cars.Add(car);
        }

        string filter = Console.ReadLine();
        List<Car> filteredCars = cars.Where(x => x.Cargo.Type == filter).ToList();
        if (filter == "fragile")
        {
            filteredCars = filteredCars
                .Where(x => x.Cargo.Weight < 1000)
                .ToList();
        }
        else if (filter == "flamable")
        {
            filteredCars = filteredCars
                .Where(x => x.Engine.Power > 250)
                .ToList();
        }

        foreach (Car car in filteredCars)
        {
            Console.WriteLine(car.Model);
        }

    }
}

public class Engine
{
    public Engine(int speed, int power)
    {
        this.Speed = speed;
        this.Power = power;
    }
    public int Speed { get; set; }
    public int Power { get; set; }
}

public class Cargo
{
    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }

    public int Weight { get; set; }
    public string Type { get; set; }
}

class Car
{
    public Car(string model, Engine engine, Cargo cargo)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }


}

