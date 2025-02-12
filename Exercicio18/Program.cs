using System;

public class Programa16 
{
    public static void Main(String[] args) 
    {
        // arrays

        String[] cidades = {"Lisboa", "Porto", "Coimbra", "Faro", "braga" };
        int[] numerodepopulacao = {545000, 237000, 143000, 118000, 193000 };

        // coisas que aparecem na tela

        Console.WriteLine("Cidades e as suas populações: " + "\n");

        for (int contador = 0; contador < cidades.Length; contador++)
        {
            Console.WriteLine(cidades[contador] + " - " + numerodepopulacao[contador] + " Habitantes");
        }
    }
}
