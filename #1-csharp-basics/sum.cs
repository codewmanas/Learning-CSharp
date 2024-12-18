// Write a C# program to add two numbers accept it from user and add them , print the same.
using system;
namespace sum
{
	class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Num one:");
		  int num1 = int.Parse(Console.ReadLine());
		  Console.WriteLine("Enter Second Num:");
		  int num2 = int.Parse(Console.ReadLine());
		  int sum = num1 + num2 ;
		  Console.WriteLine("The sum of "+num1+" and "+num2+" is "+sum);
		 }
	}
}