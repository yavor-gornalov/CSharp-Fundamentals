using System;

public class Program
{
    public static void Main()
    {

        while (true)
        {
            string numString = Console.ReadLine();

            if (numString == "END") break;

            int integerNumber;
            bool canConvertInteger = int.TryParse(numString, out integerNumber);
            if (canConvertInteger == true)
            {
                Console.WriteLine($"{numString} is integer type");
                continue;
            }

            float floatNumber;
            bool canConvertFloat = float.TryParse(numString, out floatNumber);
            if (canConvertFloat == true)
            {
                Console.WriteLine($"{numString} is floating point type");
                continue;
            }

            char charValue;
            bool canConvertCharacter = char.TryParse(numString, out charValue);
            if (canConvertCharacter == true)
            {
                Console.WriteLine($"{numString} is character type");
                continue;
            }

            bool boolValue;
            bool canConvertBoolean = bool.TryParse(numString, out boolValue);
            if (canConvertBoolean == true)
            {
                Console.WriteLine($"{numString} is boolean type");
                continue;
            }

            Console.WriteLine($"{numString} is string type");
        }
    }
}