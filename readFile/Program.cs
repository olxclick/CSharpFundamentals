using System.Reflection;

namespace readFile
{
	class Program
	{
		static void Main(string[] args)
		{
			var content = File.ReadAllText("../file.txt");
			var trimmedContent = content.Trim();
			var allStrs = trimmedContent.Split(' ');
			
			foreach(string n in allStrs)
			{
				System.Console.WriteLine("Words present in file: " + n);
			}
		}
	}
}