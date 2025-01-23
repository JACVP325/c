using System;

public class Programa12 
{

    public static void Main(string[] args) 
    {   

        int resultado = MaiorMenor(30, 10);

        Console.WriteLine("Dos numeros indicados, " +resultado + " é o maior !");


       
    }
    public static int MaiorMenor(int a, int b) 
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}