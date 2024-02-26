using System.Linq;

internal class Program
{
    static void Main()
    {
        List<int> firstPlayerCards = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> secondPlayerCards = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string winner = string.Empty;
        while (true)
        {
            if (firstPlayerCards.Count == 0)
            {
                winner = "Second";
                break;
            }

            if (secondPlayerCards.Count == 0)
            {
                winner = "First";
                break;
            }
            int firstCard = firstPlayerCards.First();
            firstPlayerCards.Remove(firstCard);
            int secondCard = secondPlayerCards.First();
            secondPlayerCards.Remove(secondCard);
            int currentHand = firstCard + secondCard;

            if (firstCard > secondCard)
            {
                firstPlayerCards.Add(secondCard);
                firstPlayerCards.Add(firstCard);
            }
            else if (firstCard < secondCard)
            {
                secondPlayerCards.Add(firstCard);
                secondPlayerCards.Add(secondCard);
            }
        }

        Console.WriteLine($"{winner} player wins! Sum: {Math.Abs(firstPlayerCards.Sum() - secondPlayerCards.Sum())}");
    }
}
