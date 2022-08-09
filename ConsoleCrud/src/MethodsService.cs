using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleCrud.src
{
    public class MethodsService : IMethodsService
    {
        private List<string> _names { get; set; }
        public MethodsService(List<string> names)
        {
            _names = names;
        }
        //Método de criar
        public void Create()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome para criar:");
            var name = Console.ReadLine();
            bool validation = ValidationName(name);
            if (validation)
                _names.Add(name);
            else
                Create();
        }

        //Método de ler
        public void Read(List<string> list)
        {
            Console.Clear();
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }

        //Método de Atualizar
        public void Update(ref List<string> list)
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
            var check = _names.Where(item => item == oldName).FirstOrDefault();
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
        public void Delete(ref List<string> list)
        {
            string name;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe um nome para apagar:");
                name = Console.ReadLine();

            } while (!ValidationName(name));

            var check = _names.Where(x => x == name).FirstOrDefault();
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


        //Validação do nome

        public bool ValidationName(string name)
        {
            foreach (char letra in name) //Verifica se existe números no nome
            {
                if (letra >= '0' && letra <= '9')
                {
                    Console.WriteLine("O nome não deve conter números");
                    Console.ReadKey();
                    return false;
                }
            }
            if (name.Length >= 100 || name.Length < 3 || name.StartsWith(" ") || name.EndsWith(" ") || !name.All(char.IsLetter))
            {// Verifica o tamanho permitido, os espaços no inicio e no final e se todos os caracteres são letras 
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
