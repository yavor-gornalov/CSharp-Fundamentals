internal class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        PrintPasswordChecks(password);
    }

    private static void PrintPasswordChecks(string password)
    {
        bool isValid = true;
        if (password.Length < 6 || password.Length > 10)
        {
            isValid = false;
            Console.WriteLine("Password must be between 6 and 10 characters");
        }


        int lettersCount = 0;
        int digitsCount = 0;
        foreach (char symbol in password)
        {
            if (char.IsLetter(symbol)) lettersCount++;
            if (char.IsDigit(symbol)) digitsCount++;
        }

        if (digitsCount + lettersCount < password.Length)
        {
            isValid = false;
            Console.WriteLine("Password must consist only of letters and digits");
        }

        if (digitsCount < 2)
        {
            isValid = false;
            Console.WriteLine("Password must have at least 2 digits");
        }

        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }
}
