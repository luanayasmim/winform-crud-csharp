using System;
using System.Collections.Generic;

namespace ConsoleCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de nomes
            List<string> names = new List<string>();

            bool sair = true;

            do
            {
                Console.Clear();
                Console.WriteLine("CRUD");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Você deseja:");
                Console.WriteLine("1 - Criar");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("5 - Sair");

                var comando = Console.ReadLine();

                if (comando == "1")
                {
                    Create();
                }
                else if (comando == "2")
                {
                    Read(names);
                    Console.ReadKey();
                }
                else if (comando == "3")
                {
                    Update(ref names);
                }
                else if (comando == "4")
                {
                    Delete(ref names);
                }
                else if (comando == "5")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Valor inválido!");
                }

            }
            while (sair == true);

            //Método de criar
            void Create()
            {
                Console.Clear();
                System.Console.WriteLine("Informe um nome para criar:");
                var name = Console.ReadLine();
                names.Add(name);
            }

            //Método de ler
            void Read(List<string> list)
            {
                Console.Clear();
                foreach (var name in list)
                {
                    System.Console.WriteLine(name);
                }
            }

            //Método de Atualizar
            void Update(ref List<string> list)
            {
                Console.Clear();
                System.Console.WriteLine("Informe um nome para atualizar:");
                var oldName = Console.ReadLine();
                System.Console.WriteLine("Informe o novo nome:");
                var newName = Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == oldName)
                        list[i] = newName;
                }
            }

            //Método de apagar
            void Delete(ref List<string> list)
            {
                Console.Clear();
                System.Console.WriteLine("Informe um nome para apagar:");
                var name = Console.ReadLine();
                Console.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == name)
                        list.Remove(name);
                }
            }

        }
    }
}
