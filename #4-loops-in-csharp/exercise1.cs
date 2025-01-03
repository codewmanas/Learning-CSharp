write a simple cs program to calculate how many digits has positive integer if user enters negative integer program must show a warning message and if its positive then display total number of digits

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            if (number < 0)
            {
                Console.WriteLine("Warning: Please enter a positive integer.");
            }
            else
            {
                int digitCount = input.Length;
                Console.WriteLine($"The number {number} has {digitCount} digits.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}