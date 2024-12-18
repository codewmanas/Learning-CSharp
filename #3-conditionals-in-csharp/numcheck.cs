// C# Program to check Positive Negative and Zero
using System;

namespace numCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        if (num > 0)
        {
            Console.WriteLine($"{num} is Positive");
        }
        else if(num == 0)
        {
            Console.WriteLine($"{num} is ZERO");
        }
        else
        {
            Console.WriteLine($"{num} is Negative");    
        }
    }
}