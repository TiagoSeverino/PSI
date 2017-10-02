using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de raparigaz da turma");
            int f = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de rapazes da turma");
            int m = Int32.Parse(Console.ReadLine());

            int t = m + f;

            double mm = (double)m / (double)t * 100;
            double mf = (double)f / (double)t * 100;

            Console.WriteLine("Existem " + mf + "% de raparigas na turma e " + mm + "% de rapazes na turma");
            Console.ReadLine();
        }
    }
}
