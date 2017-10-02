using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa manel = new Pessoa("Manuel", 30, 1.84);

            Console.WriteLine("Nome: {0}, Idade: {1}, Altura: {2}", manel.getNome(), manel.getIdade(), manel.getAltura());

            Console.ReadLine();
        }
    }
}
