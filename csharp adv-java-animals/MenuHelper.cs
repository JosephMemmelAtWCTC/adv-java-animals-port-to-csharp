namespace AdvJavaAnimals;

public class MenuHelper
{
    public static int SelectFromList(string[] pickingFrom, string message)
    {
        while (true)
        {
            Console.WriteLine($"{message}:");
            for (int i = 0; i < pickingFrom.Length; ++i)
            {
                Console.WriteLine($"\t({i+1}) - {pickingFrom[i]}");
            }
            Console.Write($"Enter your choice 1-{pickingFrom.Length}: ");
            string rawInput = Console.ReadLine();
            if (int.TryParse(rawInput, out int selectionNumber))
            {
                if (selectionNumber > 0 && selectionNumber <= pickingFrom.Length)
                {
                    return selectionNumber - 1;
                }
                else
                {
                    Console.WriteLine($"Sorry but you have to select from 1-{pickingFrom.Length}");
                }
            }
            else
            {
                Console.WriteLine("You need to enter a while number");
            }
        }
    }

    public static string GetString(string message, bool trunkate, int minLength, int maxLength)
    {
        string rawInput;
        do
        {
            Console.Write($"{message} (between {minLength} and {maxLength} characters): ");
            rawInput = Console.ReadLine();

            if (trunkate)
            {
                rawInput = rawInput.Trim();
            }
            if (rawInput.Length > maxLength)
            {
                Console.WriteLine("Sorry but that response was too long.");
            }
            else if (rawInput.Length < minLength)
            {
                Console.WriteLine("Sorry but that response was too short.");
            }
        } while (rawInput.Length < minLength || rawInput.Length > maxLength);

        return rawInput;
    }
    
    public static int GetWholeNumber(string message, int min, int max)
    {
        do
        {
            Console.Write($"{message} (between {min} and {max}): ");

            if (int.TryParse(Console.ReadLine(), out int wholeNumber))
            {
                if(wholeNumber > max)
                {
                    Console.WriteLine("Sorry but that number is too high.");
                }
                else if (wholeNumber < min)
                {
                    Console.WriteLine("Sorry but that number is too low.");
                }
                else
                {
                    return wholeNumber;
                }
            }
            else
            {
                Console.WriteLine("Sorry but that was not a while number");
            }

        } while (true);
    }
    
}