using System;
using System.Collections.Generic;
using System.Linq;

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
                Menu();
                var comando = Console.ReadLine();

                if (comando == "1")
                {
                    PrintCondition();
                    Console.ReadKey();
                    Create();
                }
                else if (comando == "2")
                {
                    Read(names);
                    Console.ReadKey();
                }
                else if (comando == "3")
                {
                    PrintCondition();
                    Console.ReadKey();
                    Update(ref names);
                }
                else if (comando == "4")
                {
                    PrintCondition();
                    Console.ReadKey();
                    Delete(ref names);
                }
                else if (comando == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }

            }
            while (sair == true);

            //Método para criar o Menu
            void Menu()
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
            }

            //Método para exibir as codições dos nomes inseridos
            void PrintCondition()
            {
                Console.Clear();
                Console.WriteLine("Condições para criar o nome:");
                Console.WriteLine("O nome não pode passar de 100 caracteres;");
                Console.WriteLine("Não pode conter números ou caracteres especiais;");
                Console.WriteLine("Não pode começar ou terminar com espaços.");
                Console.WriteLine("________________________________________________");
            }

            //Método de criar
            void Create()
            {
                Console.Clear();
                Console.WriteLine("Informe um nome para criar:");
                var name = Console.ReadLine();
                bool validation = ValidationName(name);
                if (validation)
                    names.Add(name);
                else
                    Create();
            }

            //Método de ler
            void Read(List<string> list)
            {
                Console.Clear();
                foreach (var name in list)
                {
                    Console.WriteLine(name);
                }
            }

            //Método de Atualizar
            void Update(ref List<string> list)
            {
                Console.Clear();
                string oldName, newName;

                do
                {
                    Console.WriteLine("Informe um nome para atualizar:");
                    oldName = Console.ReadLine();
                }
                while (!ValidationName(oldName));

                

                //var searchBacon = myStrList.Where(item => item == "bacon").FirstOrDefault();
                //Verificando se o nome informado existe na lista
                var check = names.Where(item => item == oldName).FirstOrDefault();
                try
                {
                    if (check.Any())
                    {
                        do
                        {
                            Console.WriteLine("Informe o novo nome:");
                            newName = Console.ReadLine();
                        }
                        while (!ValidationName(newName));

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == oldName)
                                list[i] = newName;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome não encontrado (¬_¬)");
                    Console.ReadKey();

                }
                
                

            }

            //Método de apagar
            void Delete(ref List<string> list)
            {
                string name;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Informe um nome para apagar:");
                    name = Console.ReadLine();

                } while (!ValidationName(name));

                var check = names.Where(x => x == name).FirstOrDefault();
                try
                {
                    if (check.Any())
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == name)
                                list.Remove(name);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome não encontrado (¬_¬)");
                    Console.ReadKey();
                }
                
                
            }


            //Recebe nome
            bool ValidationName(string name)
            {
                foreach (char letra in name)
                {
                    if (letra >= '0' && letra <= '9')
                    {
                        Console.WriteLine("O nome não deve conter números");
                        Console.ReadKey();
                        return false;
                    }
                }
                if (name.Length >= 100 || name.Length < 3 || name.StartsWith(" ") || name.EndsWith(" ") || !name.All(char.IsLetter))
                {
                    Console.WriteLine("Informe um nome válido!");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
