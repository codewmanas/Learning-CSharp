//Accept two integer no and one char as operator and perform the following operation use only else if ladder
using System;

class Program
{
    static void Main()
    {
        // Declare variables
        int num1, num2;
        char operatorChar;

        // Get user input for two integers and an operator
        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        operatorChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Perform operation using an else-if ladder
        if (operatorChar == '+')
        {
            Console.WriteLine("Result: " + (num1 + num2));
        }
        else if (operatorChar == '-')
        {
            Console.WriteLine("Result: " + (num1 - num2));
        }
        else if (operatorChar == '*')
        {
            Console.WriteLine("Result: " + (num1 * num2));
        }
        else if (operatorChar == '/')
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine("Result: " + (num1 / num2));
            }
        }
        else
        {
            Console.WriteLine("Invalid operator.");
        }
    }
}
