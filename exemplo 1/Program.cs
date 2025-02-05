using System;

public class exemplo_1
{
    public static void Main(string[] args) 
    {
        // Arayy

        int[] IdadeAlunos = { 10, 15, 17, 18 };

        // percorrer array com FOR

        Console.WriteLine("idade percorrida com FOR");

        for (int contador = 0; contador < IdadeAlunos.Length; contador++) 
        {
            Console.WriteLine(IdadeAlunos[contador]);
        }

        // percorrer array com FOREACH

        Console.WriteLine("Idade percorrida com FOREACH");

        foreach(int idade in IdadeAlunos)
        {
            Console.WriteLine(idade);
        }
    }
}