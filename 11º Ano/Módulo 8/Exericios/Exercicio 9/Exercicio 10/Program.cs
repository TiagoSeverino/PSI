using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = getOperation();
            
            double[] n = getNumbers();

            switch (op)
            {
                case '1':
                case 'a':
                    add(n[0], n[1]);
                    break;
                case '2':
                case 's':
                    sub(n[0], n[1]);
                    break;
                case '3':
                case 'm':
                    m(n[0], n[1]);
                    break;
                case '4':
                case 'd':
                    sub(n[0], n[1]);
                    break;
                default:
                    Console.WriteLine("Opção Incorreta");
                    Console.ReadLine();
                    Main(null);
                    break;
            }
            Console.ReadLine();

            final();
        }

        static char getOperation()
        {
            Console.Clear();

            Console.WriteLine("╔══════════════════════╗\n" +
                              "║    1. Adição         ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    2. Subtração      ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    3. Multiplicação  ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    4. Divisão        ║\n" +
                              "╚══════════════════════╝");

            char o = Console.ReadLine().ToLower()[0];

            return o;
        }

        static double[] getNumbers()
        {
            Console.Clear();

            Console.WriteLine("Insira O 1º Número");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira O 2º Número");
            double n2 = double.Parse(Console.ReadLine());

            double[] n = { n1, n2 };
            return n;
        }

        static void final()
        {
            Console.Clear();

            Console.WriteLine("╔══════════════════════╗\n" +
                              "║    1. Continuar      ║\n" +
                              "╠══════════════════════╣\n" +
                              "║    2. Sair           ║\n" +
                              "╚══════════════════════╝");

            switch (Console.ReadLine().ToLower()[0])
            {
                case '1':
                case 'c':
                    Main(null);
                    break;
                case '2':
                case 's':
                    Environment.Exit(0);
                    break;
                default:
                    final();
                    break;
            }
        }

        static void add(double n1, double n2)
        {
            Console.WriteLine("O resultado é " + (n1 + n2));
        }

        static void sub(double n1, double n2)
        {
            Console.WriteLine("O resultado é " + (n1 - n2));
        }

        static void m(double n1, double n2)
        {
            Console.WriteLine("O resultado é " + (n1 * n2));
        }

        static void d(double n1, double n2)
        {
            Console.WriteLine("O resultado é " + (n1 / n2));
        }
    }
}
