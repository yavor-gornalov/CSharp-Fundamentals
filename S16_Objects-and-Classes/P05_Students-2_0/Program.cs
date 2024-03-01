
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
        List<Student> studentsList = new List<Student>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end") break;

            string[] tokens = line.Split().ToArray();

            string firstName = tokens[0];
            string lastName = tokens[1];
            int age = int.Parse(tokens[2]);
            string city = tokens[3];

            Student newStudent = isStudentExists(studentsList, firstName, lastName);

            if (newStudent == null)
            {
                studentsList.Add(new Student(firstName, lastName, age, city));
                continue;
            }
            newStudent.Age = age;
            newStudent.HomeTown = city;
        }

        string targetCity = Console.ReadLine();


        foreach (Student student in studentsList)
        {
            if (student.HomeTown == targetCity) student.PrintInfo();
        }
    }

    private static Student isStudentExists(List<Student> studentsList, string firstName, string lastName)
    {
        foreach (Student student in studentsList)
        {
            if (student.FirstName == firstName && student.LastName == lastName) return student;
        }
        return null;
    }
}

