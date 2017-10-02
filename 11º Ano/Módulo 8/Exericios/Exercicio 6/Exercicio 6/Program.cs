using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 150, m = 110, jc = 2, mc = 6, a = 0;

            while (m<=j)
            {
                j += jc;
                m += mc;
                a++;
            }

            Console.WriteLine("Vão demorar " + a + " anos para a Maria ser mais alta do queo João");
            Console.ReadLine();
        }
    }
}
