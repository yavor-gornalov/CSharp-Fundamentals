using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string firstName = tokens[0];
            string lastName = tokens[1];
            double grade = double.Parse(tokens[2]);

            Student newStudent = new Student(firstName, lastName, grade);

            students.Add(newStudent);
        }

        foreach (Student student in students.OrderBy(x => -x.Grade))
        {
            Console.WriteLine(student.ToString());
        }
    }
}

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}