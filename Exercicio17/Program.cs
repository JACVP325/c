using System;

public class Programa15
{
    public static void Main(string[] args) 
    {
        // arrays

        string[] nomefilmes = {"Harry potter", "Zorro", "Simpsons" };
        int[] anofilmes = {1999, 2010, 2014 };

        // coisas que aparecem na tela

        Console.WriteLine("Lista de filmes: ");

        for (int contador = 0; contador < anofilmes.Length; contador++)
        {
            Console.WriteLine(nomefilmes[contador] + " - " + anofilmes[contador]);
        }
    }
}