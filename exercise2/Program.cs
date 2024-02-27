using System;
using System.ComponentModel;

namespace maxNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int	sum = 0;
			bool	exit = false;
	
			System.Console.WriteLine("Enter a number to sum or 'ok' to exit: ");
			while (!exit)
			{
				string input = Console.ReadLine();
				if (input.ToLower() == "ok")
				{
					exit = true;
				}
				else
				{
					if (int.TryParse(input, out int number))
					{
						sum += number;
					}
				}
			}
			System.Console.WriteLine($"The result is: {sum}");
		}
	}
}