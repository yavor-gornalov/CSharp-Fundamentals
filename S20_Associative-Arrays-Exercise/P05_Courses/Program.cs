internal class Program
{
    static void Main()
    {
        // { course: [ student1, ..., studentN ] }
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end")
            {
                foreach (var pair in courses)
                {
                    List<string> result = new()
                    {
                       $"{pair.Key}: {pair.Value.Count}",
                    };
                    foreach (var user in pair.Value)
                    {
                        result.Add($"-- {user}");
                    }
                    Console.WriteLine(string.Join("\n", result));
                }
                break;
            }

            string[] tokens = line.Split(" : ").ToArray();

            string course = tokens[0];
            string stiudent = tokens[1];

            if (!courses.ContainsKey(course))
            {
                courses.Add(course, new List<string>());
            }
            courses[course].Add(stiudent);
        }
    }
}
