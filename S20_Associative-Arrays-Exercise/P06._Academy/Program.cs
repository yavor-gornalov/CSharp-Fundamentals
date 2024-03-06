internal class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string student = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!studentsGrades.ContainsKey(student))
            {
                studentsGrades.Add(student, new List<double>());
            }
            studentsGrades[student].Add(grade);
        }

        foreach (var pair in studentsGrades)
        {
            double avgGrade = pair.Value.Average();
            if (avgGrade >= 4.5)
            {
                Console.WriteLine($"{pair.Key} -> {avgGrade:F2}");
            }
        }
    }
}
