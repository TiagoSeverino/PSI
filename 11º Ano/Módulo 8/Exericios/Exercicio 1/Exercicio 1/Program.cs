using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double inch_cm = 2.54;
            double cm, inch;
            Console.WriteLine("Insira As Polegadas Para Converter");

            inch = Convert.ToDouble(Console.ReadLine());

            cm = inch / inch_cm;

            Console.WriteLine(cm + "cm = " + inch + " polegadas");

            Console.WriteLine("Prima Qualquer Tecla Para Sair");
            Console.ReadLine();
        }
    }
}
