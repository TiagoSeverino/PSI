using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pare=0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira Um Número");
                if(Double.Parse(Console.ReadLine())%2 == 0)
                    pare++;
            }

            Console.WriteLine("Foram inseridos " + pare + " números pares");
            Console.ReadLine();
        }
    }
}
