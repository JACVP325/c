using System;

public class TerceiroPrograma 
{

    public static void Main(String[] args)
    {
        //exercicio 1

        //logica

        for (int contador = 0; contador <= 20; contador++)
        {
            if (contador %1 == 0)
            {
                Console.WriteLine(contador);
            }
        }
        for (int contador = 0; contador <= 20; contador++)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
