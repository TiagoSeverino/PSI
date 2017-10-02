using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, mins, input;

            Console.WriteLine("Insira Os Minutos");

            input = int.Parse(Console.ReadLine());

            h = input / 60;
            mins = 0;

            if (input > h*60)
            {
                mins = input - h * 60;
            }

            Console.WriteLine(input + " minutos = " + h + " horas e " + mins + " minutos");

            Console.ReadLine();

        }
    }
}
