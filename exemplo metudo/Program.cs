using System;

public class ExemploMetudo
{
    public static void Main(string[] args)
    {
        int resultado = Soma(10, 20);

        Console.WriteLine("A soma é " + resultado);
    }

    static int Soma(int a, int b) 
    {
        return a + b;
    }
    
}
