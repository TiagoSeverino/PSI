using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char op = getOperation();

                double[] n = getNumbers();

                switch (op)
                {
                    case '1':
                    case 'm':
                        imc(n[0], n[1] , 'm');
                        break;
                    case '2':
                    case 'f':
                        imc(n[0], n[1], 'f');
                        break;
                    default:
                        Console.WriteLine("Opção Incorreta");
                        Console.ReadLine();
                        Main(null);
                        break;
                }
                Console.ReadLine();

                Console.Clear();

                Console.WriteLine("╔══════════════════════╗\n" +
                                  "║    1. Continuar      ║\n" +
                                  "╠══════════════════════╣\n" +
                                  "║    2. Sair           ║\n" +
                                  "╚══════════════════════╝");
                switch (Console.ReadLine().ToLower()[0])
                {
                    case '2':
                    case 's':
                        Environment.Exit(0);
                        break;
                }
            }
            while (true);
        }

        static char getOperation()
        {
            Console.Clear();

            Console.WriteLine("╔══════════════════════╗\n" +
                              "║      Peso Ideal      ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    1. Masculino      ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    2. Feminino       ║\n" +
                              "╚══════════════════════╝");

            char o = Console.ReadLine().ToLower()[0];

            return o;
        }

        static double[] getNumbers()
        {
            Console.Clear();

            Console.WriteLine("Insira a altura");
            double n1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Insira o peso");
            double n2 = 0;//double.Parse(Console.ReadLine());

            double[] n = { n1, n2 };
            return n;
        }

        static void imc(double n1, double n2, char s)
        {
            double imc = 0;

            if (s == 'm')
            {
                imc = (72.7 * n1) - 58;
            }
            else
            {
                imc = (62.1 * n1) - 44.7;
            }

            Console.WriteLine("O seu peso ideal é de " + imc + "kg");
        }
    }
}
