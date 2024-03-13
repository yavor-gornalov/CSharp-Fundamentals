using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static bool IsTicketValid(string ticket)
    {
        return ticket.Length == 20;
    }

    static (int, char) GetCombinationsLengthAndSymbol(string ticket)
    {
        string winningSymbols = "@#$^";

        int winningCombination = 0;
        char winningSymbol = '\0';

        foreach (char symbol in winningSymbols)
        {
            string pattern = $"\\{symbol}+";
            Regex re = new Regex(pattern);
            Match first = re.Match(ticket.Substring(0, 10));
            Match second = re.Match(ticket.Substring(10));

            if (first.Success && second.Success)
            {
                int currentTiccetCombinationLength = Math.Min(first.Length, second.Length);
                winningCombination = Math.Max(winningCombination, currentTiccetCombinationLength);
                winningSymbol = symbol;
            }
        }

        return (winningCombination, winningSymbol);
    }

    static string CheckTicket(string ticket)
    {
        if (!IsTicketValid(ticket))
            return "invalid ticket";

        (int combinationLength, char symbol) = GetCombinationsLengthAndSymbol(ticket);

        if (combinationLength < 6)
            return $"ticket \"{ticket}\" - no match";

        if (combinationLength < 10)
            return $"ticket \"{ticket}\" - {combinationLength}{symbol}";

        return $"ticket \"{ticket}\" - {combinationLength}{symbol} Jackpot!";
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tickets = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(t => t.Trim()).ToArray();

        foreach (string currentTicket in tickets)
        {
            Console.WriteLine(CheckTicket(currentTicket));
        }
    }
}
