using System;

public class Programa14 
{
    public static void Main(string[] args) 
    {
        ParImpar(10);
    }
    public static void ParImpar(int n1)
    {
        if (n1 % 2 == 0)
        {
            Quadrado(n1);
        }
        else
        {
            Console.WriteLine("O númere não é par por isso não é possivel" +
                " calcular o valor ao quadrado");
        }
    }
    public static void Quadrado(int n2) 
    {
        int resultado = n2 * n2;

        Console.WriteLine("O valor " +n2 + " ao quadrado é " + resultado);
    }
}