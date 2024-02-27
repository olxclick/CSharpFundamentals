using System;

namespace Exercise4
{
	class Program 
	{
		static void Main(string[] args)
		{
			int	speed, carSpeed, diff, num = 0;

			Console.WriteLine("Qual é a velocidade máxima na zona?");
			speed = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("A que velocidade ia o veiculo?");
			carSpeed = Convert.ToInt32(Console.ReadLine());

			if (carSpeed > speed)
			{
				diff = carSpeed - speed;
				while (diff != 0)
				{
					num++;
					diff = diff - 5;
				}
				if (num >= 12)
				{
					Console.WriteLine("Ficaste sem carta...");
				}
				else
				{
					System.Console.WriteLine("Perdeste " + num + " pontos");
				}
			}
			else
				Console.WriteLine("Ok");
		}
		
	}
}