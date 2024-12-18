/*  C# program to create two variables one with name positive and other one negative , 
both are of type boolean (bool) follow the procedure for define if positive and negative
are true then display light is on if positive is true and negative is false display light
is off if positive is false and negative is true display light is off
 if any other case display message "please plug in"  */
 using System;

class Program
{
    static void Main()
    {
        // Declare two boolean variables
        bool positive, negative;

        // Get user input for positive and negative values
        Console.Write("Enter value for 'positive' (true/false): ");
        positive = bool.Parse(Console.ReadLine());

        Console.Write("Enter value for 'negative' (true/false): ");
        negative = bool.Parse(Console.ReadLine());

        // Check the conditions and display the appropriate message
        if (positive && negative)
        {
            Console.WriteLine("Light is ON");
        }
        else if (positive && !negative)
        {
            Console.WriteLine("Light is OFF");
        }
        else if (!positive && negative)
        {
            Console.WriteLine("Light is OFF");
        }
        else
        {
            Console.WriteLine("Please plug in");
        }
    }
}
