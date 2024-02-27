// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
// otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

using System.Data;
using System.Transactions;

namespace checkTime
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Enter a time avalue in the 24 hour format:");
			var input = Console.ReadLine();
			if (String.IsNullOrEmpty(input))
			{
				System.Console.WriteLine("Invalid Time");
				return;
			}
			var time = input.Split(':');

			if (time.Length != 2)
			{
				System.Console.WriteLine("Invalid Time");
				return;
			}
			if (int.TryParse(time[0], out int hours) && int.TryParse(time[1], out int minutes))
			{
				if ((hours > 0 && hours < 24) && (minutes > 0 && minutes < 60))
				{
					System.Console.WriteLine("OK!");
					return;
				}
				else
				{
					System.Console.WriteLine("Invalid Time");
					return;
				}
			}
			else
			{
				System.Console.WriteLine("Invalid Time");
				return;
			}
		}
	}
}