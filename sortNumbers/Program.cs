//Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered, display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

namespace sortNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Write 5 unique numbers: ");
			var numbers = new int[5];
			int i = 0;

			while(i < numbers.Length)
			{
				if (int.TryParse(Console.ReadLine(), out int input))
				{
					if (Array.IndexOf(numbers, input) == -1)
					{
						numbers[i] = input;
						i++;
					}
					else
					{
						System.Console.WriteLine("Number already given.");
					}
				}
			}
			Array.Sort(numbers);

			Console.WriteLine("Sorted numbers:");
			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}

		}
	}
}