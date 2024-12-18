//Write a C# program to swap two numbers stored in variables only by using two variables
using System;

class Program
{
    static void Main()
    {
       
        int a, b;

       
        Console.Write("Enter the first number (a): ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (b): ");
        b = int.Parse(Console.ReadLine());

        
        a = a + b; // a now holds the sum of a and b
        b = a - b; // b now becomes the original value of a
        a = a - b; // a now becomes the original value of b

        
        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
