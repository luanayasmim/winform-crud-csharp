using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrud.src
{
    public class MenuService : IMenuService
    {
        public MenuService()
        {
        }

        //Método para criar o Menu
        public void Menu()
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
        public void PrintCondition()
        {
            Console.Clear();
            Console.WriteLine("Condições para criar o nome:");
            Console.WriteLine("O nome não pode passar de 100 caracteres;");
            Console.WriteLine("Não pode conter números ou caracteres especiais;");
            Console.WriteLine("Não pode começar ou terminar com espaços.");
            Console.WriteLine("________________________________________________");
        }
    }
}
