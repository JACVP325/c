using System;

public class SextoProgarma 
{
	public static void Main(string[] args) 
	{
		int nota = 90;

		switch (nota)
		{
			case int n when (n >= 90):
				Console.WriteLine("A tua nota final é um S");
				break;
			case int n when (n >= 80):
				Console.WriteLine("A tua nota final é um A");
				break;
			case int n when (n >= 70):
				Console.WriteLine("A tua nota final é um B");
				break;
			case int n when (n >= 60):
				Console.WriteLine("A tua nota final é um C");
			    break;
			case int n when (n >= 50):
				Console.WriteLine("A tua nota final é um D");
				break;
			case int n when (n < 50):
				Console.WriteLine("A tua nota final é um F (reprovado)");
				break;
			default:
				Console.WriteLine("A tua nota final é desconhecida");
				break;
		}
	}
}
