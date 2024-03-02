internal class Program
{
    static void Main()
    {
        List<Person> personalInfo = new List<Person>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End")
            {
                PrintPersonalInfo(personalInfo);
                break;
            }

            string[] tokens = line.Split().ToArray();
            string name = tokens[0];
            string id = tokens[1];
            int age = int.Parse(tokens[2]);

            if (PersonExists(personalInfo, id))
            {
                Person personToUpdate = GetPersonById(personalInfo, id);
                personToUpdate.Name = name;
                personToUpdate.Age = age;
                continue;
            }

            Person personToAdd = new Person(id, name, age);
            personalInfo.Add(personToAdd);
        }
    }

    public static bool PersonExists(List<Person> info, string id)
        => info.Any(p => p.Id == id);

    public static Person GetPersonById(List<Person> info, string id)
        => info.First(p => p.Id == id);

    public static void PrintPersonalInfo(List<Person> info)
    {
        foreach (Person person in info.OrderBy(p => p.Age))
        {
            Console.WriteLine(person.ToString());
        }
    }

}
public class Person
{
    public Person(string id, string name, int age)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
    }

    public string Id { get; private set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
        => $"{Name} with ID: {Id} is {Age} years old.";
}
