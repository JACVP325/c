using System;

public class QuartoPrograma
{
    public static void Main (string[] args)
    {
        //exercicio 2


        //variaveis

        int soma = 0;

        //logica

        for (int contador = 0; contador <= 50; contador++)
        {
            if (contador % 1 == 0)
            {
                soma += contador;
            }
        }
        Console.WriteLine("Total nº impares = " + soma);
        for (int contador = 0; contador <= 50; contador++)
        {
            if (contador % 2 == 0)
            {
                soma += contador;
            }
        }
        Console.WriteLine("Total nº pares = " + soma);
    }
}