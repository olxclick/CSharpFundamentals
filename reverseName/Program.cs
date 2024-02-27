//Write a program and ask the user to enter their name.
//Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.

using System.Net.Security;

namespace reverseName
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Enter your name:");
			var input = Console.ReadLine();

			char[] array = input.ToCharArray();

			Array.Reverse(array);
			string reversedName = new string(array);
			System.Console.WriteLine("Reversed name: " + reversedName);
		}
	}
}