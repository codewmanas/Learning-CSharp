// Write a C# program to take input minutes and display it in hours and minutes format 
using System;

public class Program
{
    public static void Main(string[] args)
    {
     Console.Write("Enter the total minutes: ");
        int totalMinutes = int.Parse(Console.ReadLine());

        
        int hours = totalMinutes / 60;   // Calculate hours
        int minutes = totalMinutes % 60; // Calculate remaining minutes

        
        Console.WriteLine($"{totalMinutes} minutes is equal to {hours} hour(s) and {minutes} minute(s).");
    }
}