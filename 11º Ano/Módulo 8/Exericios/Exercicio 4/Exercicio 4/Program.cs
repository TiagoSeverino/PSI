using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nr, quadrado;
            Console.WriteLine("Insira o número para obter o quadrado:");

            nr = Double.Parse(Console.ReadLine());

            quadrado = nr * nr;

            Console.WriteLine("O quadrado de " + nr + " é " + quadrado);
            Console.ReadLine();
        }
    }
}
