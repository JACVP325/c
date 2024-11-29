using System;
    internal class SetimoPrograma
    {
        static void Main(string[] args)
        {
            int nota = -1;

            switch (nota) 
            {
                case int n when (n >= 18):
                Console.WriteLine("A tua nota final é um excelete");
                break;
                case int n when (n >= 14):
                Console.WriteLine("A tua nota final é um bom");
                break;
                case int n when (n >= 10):
                Console.WriteLine("A tua nota final é um suficiente");
                break;
                case int n when (n >= 0):
                Console.WriteLine("A tua nota final é um insuficiente");
                break;
                default:
                Console.WriteLine("Nota invalida");
                break;
            }
        }
    }
