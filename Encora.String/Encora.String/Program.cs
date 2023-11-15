using Encora.String.services;

class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {
            Console.Clear();
            Console.WriteLine("\n\nWelcome to String Manipulation: Sort of String");
            Console.WriteLine("------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter a string to validate (or a number to check if it's a number):");
            Console.ResetColor();
            string inputText = Console.ReadLine();

            if (!int.TryParse(inputText, out _))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string sortedString = StringSorter.SortStringByFrequency(inputText);     
                Console.Write($"Sorted String: ");
                Console.ResetColor();
                Console.WriteLine($"{sortedString}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("The input is a number.");
            }

            Console.WriteLine("\nDo you want to process another string? (yes/no)");
            string answer = Console.ReadLine().Trim().ToLower();

            repeat = answer == "yes";
        }
    }
}
