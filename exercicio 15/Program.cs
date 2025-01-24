using System;

public class Programa13 
{
    public static void Main(string[] args)
    {
        //dados

        bool resultado = ParImpar (10);

        //logca

        if (resultado == true)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O númer é impar");
        }
    }
    public static bool ParImpar(int a) 
    {
        return (a % 2 == 0);
    }
}