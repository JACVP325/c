using System;

public class ExmploBreak 
{
    public static void Main(string[] args)
    {
        for(int contador = 1; contador <= 10; contador++) 
        {
            if (contador == 5)
            {
                break;
            }
            Console.WriteLine(contador);
        }
    }
}