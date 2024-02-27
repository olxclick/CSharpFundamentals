using System;

namespace CSharpFundamentals
{
	public class Car
	{
		internal string make { get; set; }
		internal string model { get; set; }
		internal int year { get; set; }
		
		public	Car(string Make, string Model, int Year)
		{
			make = Make;
			model = Model;
			year = Year;
		}
		public void Sell()
		{
			Console.WriteLine("We have got a " + make + " " + model + " from " + year);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var car = new Car("BMW", "M3", 1999);
			car.Sell();

			var firstName = "johnn";
			var lastName = "lazaro";
			char quo = ' ';

			var fullName = string.Concat(firstName, quo, lastName);
			System.Console.WriteLine("It currently belongs to: " + fullName);
			System.Console.WriteLine("this has a newline to the next word\nSHOULDBENEWLINED");
			System.Console.WriteLine(@"this should not have a newline to the next word\nSHOULD NOT BE NEWLINED");
		}
	}
}


