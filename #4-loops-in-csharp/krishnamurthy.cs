C# program to check if a number is Krishnamurthy number or not.

using System;

class Program
{
    static void Main()
    {
        int number, temp, remainder, sum = 0;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        temp = number;

        do
        {
            remainder = temp % 10;
            sum += Factorial(remainder);
            temp /= 10;
        } while (temp > 0);

        if (sum == number)
        {
            Console.WriteLine($"{number} is a Krishnamurthy number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Krishnamurthy number.");
        }
    }

    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}