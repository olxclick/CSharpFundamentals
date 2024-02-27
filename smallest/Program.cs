//Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
//If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try
//otherwise, display the 3 smallest numbers in the list.

using System.Runtime;

namespace smallest
{
	class Program
	{
		static void Main(string[] args)
		{
			var myList = new List<int>();
			bool finished = false;
			string[] subStrings;
			int i = 0;

			do
			{
				System.Console.WriteLine("Give me a list of numbers separated by a comma:");
				var input = Console.ReadLine();
				if (String.IsNullOrEmpty(input))
				{
					return;
				}
				subStrings = input.Split(',');

				if (subStrings.Length >= 5)
				{
					foreach(string str in subStrings)
					{
						if(int.TryParse(str, out int number))
						{
							myList.Add(number);
						}
					}
					finished = true;
					myList.Sort();
					while (i < 3)
					{
						System.Console.WriteLine("Number in list: " + myList[i]);
						i++;
					}
				}
				else
				{
					System.Console.WriteLine("Invalid list.");
				}
			}
			while (!finished);
		}
	}
}
