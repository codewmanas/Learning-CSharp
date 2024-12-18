// C# Program to check even or odd:
using System;

namespace evenOdd
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number : ");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is even ");
            
        }
        else
        {
            Console.WriteLine($"{num} is odd.");
        }
    }
}