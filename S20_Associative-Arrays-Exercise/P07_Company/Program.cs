internal class Program
{
    static void Main()
    {
        // { company: [ id1, ..., idN ] }
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End")
            {
                foreach (var pair in companies)
                {
                    List<string> result = new() { pair.Key };
                    foreach (string employeeId in pair.Value)
                    {
                        result.Add($"-- {employeeId}");
                    }
                    Console.WriteLine(string.Join("\n", result));
                }
                break;
            }

            string[] tokens = line
                .Split(" -> ")
                .ToArray();

            string company = tokens[0];
            string id = tokens[1];

            if (!companies.ContainsKey(company))
            {
                companies.Add(company, new List<string>());
            }

            if (!companies[company].Contains(id))
            {
                companies[company].Add(id);
            }
        }
    }
}
