public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} is {Age} years old.");
    }
}
internal class Program
{
    static void Main()
    {
        List<Student> StudentsList = new List<Student>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end") break;

            string[] tokens = line.Split().ToArray();

            StudentsList.Add(new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]));

        }

        string targetCity = Console.ReadLine();


        foreach (Student student in StudentsList)
        {
            if (student.HomeTown == targetCity) student.PrintInfo();
        }
    }
}

