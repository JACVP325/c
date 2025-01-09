using System;

public class NonoPrograma 
{
    public static void Main(string[] args)
    {
        int contador = 1;
        int soma = 0;

        do 
        {
            soma = contador + soma;
            contador++;
            Console.WriteLine(soma);
            
        }
        while (soma < 100);
        Console.WriteLine(contador - 1);
    }
}