// Write a Program to find maximum between three numbers (Nested if)
using System;

class Program
{
    static void Main()
    {
        // Declare three variables
        int num1, num2, num3;

        // Get user input for the three numbers
        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        num3 = int.Parse(Console.ReadLine());

        // Find the maximum using nested if-else
        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                Console.WriteLine("The maximum number is: " + num1);
            }
            else
            {
                Console.WriteLine("The maximum number is: " + num3);
            }
        }
        else
        {
            if (num2 >= num3)
            {
                Console.WriteLine("The maximum number is: " + num2);
            }
            else
            {
                Console.WriteLine("The maximum number is: " + num3);
            }
        }
    }
}
