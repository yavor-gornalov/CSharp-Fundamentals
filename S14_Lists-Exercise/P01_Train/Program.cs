internal class Program
{
    static void Main()
    {
        List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());


        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end")
            {
                Console.WriteLine(string.Join(" ", train));
                break;
            }
            else if (line.StartsWith("Add"))
            {
                int newWagon = int.Parse(line.Split()[1]);
                train.Add(newWagon);
            }
            else
            {
                int passedgers = int.Parse(line);
                for (int i = 0; i < train.Count; i++)
                {
                    if (train[i] + passedgers <= maxCapacity)
                    {
                        train[i] += passedgers;
                        break;
                    }
                }
            }
        }
    }
}
