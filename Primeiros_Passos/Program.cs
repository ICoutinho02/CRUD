using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiros_Passos
{
    class Program
    {
        static void Criarmenu()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Digite C para criar um nome");
            Console.WriteLine("**************************************");
            Console.WriteLine("Digite R para ler os nomes salvos");
            Console.WriteLine("**************************************");
            Console.WriteLine("Digite U para atualizar um nome salvo");
            Console.WriteLine("**************************************");
            Console.WriteLine("Digite D para deletar um nome");
            Console.WriteLine("**************************************");
        }
        private static List<string> ListaNome = new List<string>{

        };
        static void Main(string[] args)
        {
            Criarmenu();
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey(true);
                Console.WriteLine(tecla.Key.ToString());

                if (tecla.Key == ConsoleKey.C)
                {
                    Console.WriteLine("Criar um nome");
                    Console.WriteLine("Digite um nome: ");
                    string nome = Console.ReadLine();

                    ListaNome.Add(nome);
                    Console.Clear();
                    Criarmenu();
                }
                else if (tecla.Key == ConsoleKey.R)
                {
                    Console.WriteLine("Verificar nomes");
                    foreach (string valornome in ListaNome)
                    {
                        Console.WriteLine(valornome);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Criarmenu();
                }
                else if (tecla.Key == ConsoleKey.U)
                {
                    Console.WriteLine("Qual nome deseja alterar: ");
                    string nome = Console.ReadLine();
                    string[] teste = new string[10];

                    for (int contador = 0; contador < ListaNome.Count; contador++)
                    {
                        if (ListaNome[contador] == nome)
                        {
                            Console.WriteLine("Digite o novo nome: ");
                            ListaNome[contador] = Console.ReadLine();
                        }
                    }
                    Console.WriteLine("O nome foi alterado com sucesso!");
                    Console.ReadKey();
                    Console.Clear();
                    Criarmenu();
                }
                else if (tecla.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Digite o nome que deseja remover: ");
                    string nome = Console.ReadLine();

                    for (int i = 0; i < ListaNome.Count; i++)
                    {
                        if (nome == ListaNome[i])
                        {
                            ListaNome.Remove(nome);
                        }
                    }
                    Console.WriteLine("Seu nome foi removido com sucesso!");
                    Console.ReadKey();
                    Console.Clear();
                    Criarmenu();
                }
                else if (tecla.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Remover Nomes");
                }
                else
                    Console.WriteLine("Opção Inválida!");

            } while (tecla.Key != ConsoleKey.F);
            Console.WriteLine("O programa será finalizado!");
            Console.ReadLine();
        }
    }
}