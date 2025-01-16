using System;

public class Programa11 
{
    public static void Main(string[] args) 
    {
        //dados

        int contador = 1;

        //logica

        do
        {
            Console.WriteLine(contador);

            contador++;

        }
        while (contador <= 5);

        //saida

        Console.WriteLine("Contagem comcluida parabems");
    }
}