using System;

public class QuintoPrograma
{
	public static void Main(string[] args)
	{
		int idade = 6;

		switch (idade)
		{
			case 1:
				Console.WriteLine("hoje é domingo");
				break;
			case 2:
				Console.WriteLine("hoje é segunda feira");
				break;
			case 3:
				Console.WriteLine("hoje é terça feira");
				break;
			case 4:
				Console.WriteLine("hoje é quarta feira");
				break;
			case 5:
				Console.WriteLine("hoje é quinta feira");
				break;
			case 6:
				Console.WriteLine("hoje é sexta feira");
				break;
			case 7:
				Console.WriteLine("hoje é sabado");
				break;
			default:
				Console.WriteLine("Não conheso este dia da semana");
				break;
		}
	}
}