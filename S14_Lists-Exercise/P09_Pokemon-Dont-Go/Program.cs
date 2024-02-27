internal class Program
{
    static void Main()
    {
        List<int> pokemons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int score = 0;
        while (pokemons.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            int currentValue = 0;

            if (index < 0)
            {
                currentValue = pokemons[0];
                pokemons.RemoveAt(0);
                pokemons.Insert(0, pokemons[^1]);
            }

            else if (index >= pokemons.Count)
            {
                currentValue = pokemons[^1];
                pokemons.RemoveAt(pokemons.Count - 1);
                pokemons.Add(pokemons[0]);
            }
            else
            {
                currentValue = pokemons[index];
                pokemons.RemoveAt(index);
            }

            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= currentValue)
                {
                    pokemons[i] += currentValue;
                }
                else
                {
                    pokemons[i] -= currentValue;
                }
            }
            score += currentValue;
        }
        Console.WriteLine(score);
    }
}
