using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string (press Enter on empty line to exit):");

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            bool startsWithUpper = input.StartsWithUpper();
            Console.WriteLine($"'{input}' starts with uppercase: {(startsWithUpper ? "Yes" : "No")}\n");
        }

        Console.WriteLine("Program ended.");
    }
}