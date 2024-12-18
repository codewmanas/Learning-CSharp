// Write a C# program to find the area of Rectangle and print the same (user input required)
using system;
namespace area
{
	class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Length:");
		  int len = int.Parse(Console.ReadLine());
		  Console.WriteLine("Enter Breadth:");
		  int bred = int.Parse(Console.ReadLine());
		  int area = len + bred ;
		  Console.WriteLine("The area of Reactangle is "+area);
		 }
	}
}