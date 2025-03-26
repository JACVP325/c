using System;

public class programa18
{
    public static void Main(String[] args)
    {
        // Tipos de variáveis

        double numeroComVirgula = 3.1416;
        double numeroDouble = 1234.1416;
        long numeroGrande = 300000;
        char letra = 'j';
        int numeroInt = 282;

        // Conversão de double para inteiro

        int numeroInteiro = Convert.ToInt32(numeroComVirgula);
        Console.WriteLine("o numero " +numeroComVirgula + " convertido para inteiro é "+numeroInteiro);

        // Conversão de long para inteiro

        int numeroInteiro2 = Convert.ToInt32(numeroGrande);
        Console.WriteLine("o numero " + numeroGrande + " convertido para inteiro é " + numeroInteiro2);

        // Conversão de char para ASCII

        int ascii = (int)letra;
        Console.WriteLine("o letra " + letra + " convertido para ASCII é " + ascii);

        // Conversão de inteiro para byte

        byte numeroByte = (byte)numeroInt;
        Console.WriteLine("o numero " + numeroInt + " convertido para byte é " + numeroByte);

        // Conversão de double para float

        float numeroFloat = (float)numeroDouble;
        Console.WriteLine("o numero " + numeroDouble + " convertido para float é " + numeroFloat);
    }
}