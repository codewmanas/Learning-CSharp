using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the start number: ");
        int startNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the end number: ");
        int endNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Even numbers between {0} and {1} are:", startNumber, endNumber);
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}