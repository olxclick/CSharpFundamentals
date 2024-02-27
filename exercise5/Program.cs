//Write a program and ask the user to enter a series of numbers separated by comma. 
//Find the maximum of the numbers and display it on the console. 
//For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

using System;

namespace exercise5
{
	class Program
	{
		static void Main(string[] args)
		{
			int maxNumber = 0;
			System.Console.WriteLine("Enter a series of numbers separated by a comma:");

			string input = Console.ReadLine();
			string[] subStrings = input.Split(',');

			foreach(string str in subStrings)
			{
				if (int.TryParse(str.Trim(), out int number))
				{
					if (number > maxNumber)
					{
						maxNumber = number;
					}
				}
			}
			System.Console.WriteLine($"The maxNumber is: {maxNumber}");
		}
	}
}