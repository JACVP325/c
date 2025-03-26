using System;

public class programa18
{
    public static void Main(String[] args)
    {
        // Tipos de vari�veis

        double numeroComVirgula = 3.1416;
        double numeroDouble = 1234.1416;
        long numeroGrande = 300000;
        char letra = 'j';
        int numeroInt = 282;

        // Convers�o de double para inteiro

        int numeroInteiro = Convert.ToInt32(numeroComVirgula);
        Console.WriteLine("o numero " +numeroComVirgula + " convertido para inteiro � "+numeroInteiro);

        // Convers�o de long para inteiro

        int numeroInteiro2 = Convert.ToInt32(numeroGrande);
        Console.WriteLine("o numero " + numeroGrande + " convertido para inteiro � " + numeroInteiro2);

        // Convers�o de char para ASCII

        int ascii = (int)letra;
        Console.WriteLine("o letra " + letra + " convertido para ASCII � " + ascii);

        // Convers�o de inteiro para byte

        byte numeroByte = (byte)numeroInt;
        Console.WriteLine("o numero " + numeroInt + " convertido para byte � " + numeroByte);

        // Convers�o de double para float

        float numeroFloat = (float)numeroDouble;
        Console.WriteLine("o numero " + numeroDouble + " convertido para float � " + numeroFloat);
    }
}