using System;
using System.Collections.Generic;

public class programa17
{
    public static void Main(String[] arg)
    {
        // criar um dicionario de contactos

        Dictionary<string, string> ListaTelefonica = new Dictionary<string, string>();

        while (true)
        {
            // menu

            Console.WriteLine("escolha uma opeção");
            Console.WriteLine("1-adicionar contacto");
            Console.WriteLine("2-pesquisar contacto");
            Console.WriteLine("3-remover contacto");
            Console.WriteLine("4-sair");

            // pedir ao utilizador para escolher uma opção

            string opção = Console.ReadLine();


            switch (opção)
            {
                // adicionar contacto

                case "1":
                    Console.WriteLine("nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("numero: ");
                    string numero = Console.ReadLine();

                    ListaTelefonica.Add(nome, numero);

                    Console.WriteLine("Contacto adicionado com sucesso.");

                    break;

                // pesquisar contacto

                case "2":

                    Console.WriteLine("Insira o nome a procurar: ");
                    nome = Console.ReadLine();

                    if (ListaTelefonica.ContainsKey(nome))
                    {
                        Console.WriteLine("nome: " + nome);
                        Console.WriteLine("numero: " + ListaTelefonica[nome]);
                    }
                    else
                    {
                        Console.WriteLine("o contacto não foi encontrado");
                    }

                    break;

                // remover contacto

                case "3":

                    Console.WriteLine("Insira o nome a procurar: ");
                    nome = Console.ReadLine();

                    if (ListaTelefonica.ContainsKey(nome))
                    {
                        ListaTelefonica.Remove(nome);

                        Console.WriteLine("contacto removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("o contacto não foi encontrado");
                    }
                    break;

                // sair 

                case "4":
                    Console.WriteLine("o programa fechou");
                    return;


                default:
                    Console.WriteLine("opeção invalida");
                    break;
            }
        }

    }
}