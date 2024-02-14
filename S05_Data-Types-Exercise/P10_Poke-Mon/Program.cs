namespace P10_Poke_Mon
{
    internal class Program
    {
        static void Main()
        {
            int initialPokemonPower = int.Parse(Console.ReadLine());
            int distanceToTarget = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetsCounter = 0, pokemonPower = initialPokemonPower;
            while (pokemonPower >= distanceToTarget)
            {
                if (pokemonPower == initialPokemonPower / 2.0)
                {
                    if (exhaustionFactor > 1)
                    {
                        pokemonPower /= exhaustionFactor;
                        continue;
                    }
                }
                targetsCounter += 1;
                pokemonPower -= distanceToTarget;

            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetsCounter);
        }
    }
}
