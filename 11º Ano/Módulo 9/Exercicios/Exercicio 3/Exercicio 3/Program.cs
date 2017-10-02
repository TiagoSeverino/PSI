using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Porquinho piggy = new Porquinho();
            
            piggy.abanar();
            piggy.encher(100);
            piggy.abanar();
            piggy.visor();
            piggy.tirar(20);
            piggy.visor();

            Console.WriteLine("O que vais compar");
            Console.ReadLine();
            Console.WriteLine("Quanto custa?");
            double saldo = 0;
            if (piggy.montanteSuficiente(double.Parse(Console.ReadLine()), ref saldo))
            {
                Console.WriteLine("Podes comprar e ainda ficas com {0} euros", saldo);
            }
            else
            {
                Console.WriteLine("Não há dinheiro suficiente, tens {0} euros no mealheiro", saldo);
            }

            Console.ReadLine();
        }
    }
}
