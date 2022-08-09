using System;
using System.Collections.Generic;
using ConsoleCrud.src;
namespace ConsoleCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de nomes
            List<string> names = new List<string>();
            IMenuService menu = new MenuService();
            IMethodsService methods = new MethodsService(names);
            bool sair = true;

            do
            {
                menu.Menu();
                var comando = Console.ReadLine();

                if (comando == "1")
                {
                    menu.PrintCondition();
                    Console.ReadKey();
                    methods.Create();
                }
                else if (comando == "2")
                {
                    methods.Read(names);
                    Console.ReadKey();
                }
                else if (comando == "3")
                {
                    menu.PrintCondition();
                    Console.ReadKey();
                    methods.Update(ref names);
                }
                else if (comando == "4")
                {
                    menu.PrintCondition();
                    Console.ReadKey();
                    methods.Delete(ref names);
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

        }
    }
}
