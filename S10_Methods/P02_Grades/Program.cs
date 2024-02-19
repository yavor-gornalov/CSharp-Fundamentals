internal class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        string result = CheckGrade(grade);
        Console.WriteLine(result);
    }

    private static string CheckGrade(double grade)
    {
        switch (grade)
        {
            case < 2: return string.Empty;
            case < 3: return "Fail";
            case < 3.5: return "Poor";
            case < 4.5: return "Good";
            case < 5.5: return "Very good";
            case <= 6: return "Excellent";
            default: return string.Empty;
        }
    }
}
