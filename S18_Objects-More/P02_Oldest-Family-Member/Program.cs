internal class Program
{
    static void Main()
    {
        Family myFamily = new Family();

        int N = int.Parse(Console.ReadLine());

        FamilyConstructor(myFamily, N);

        Person oldestMember = myFamily.GetOldestMember();

        Console.WriteLine(oldestMember.ToString());
    }

    private static void FamilyConstructor(Family family, int N)
    {
        for (int i = 0; i < N; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            Person newMember = new Person(name, age);
            family.AddMember(newMember);
        }
    }
}

public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
        => $"{Name} {Age}";
}

public class Family
{
    private List<Person> members = new List<Person>();

    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person member)
        => members.Add(member);

    public Person GetOldestMember()
        => members.OrderByDescending(m => m.Age).First();
}