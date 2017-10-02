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
            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.altura = 9;
            rectangulo1.comprimento = 12;

            Console.WriteLine("Rectangulo1: Hipotenusa: " + rectangulo1.getHipotenusa() + " Área: " + rectangulo1.getArea() + " Perimetro: " + rectangulo1.getPerimetro());
            Console.ReadLine();
        }
    }

    class Rectangulo
    {
        public double comprimento, altura;

        public double getHipotenusa()
        {
            return Math.Sqrt((altura * altura) + (comprimento * comprimento));
        }

        public double getArea()
        {
            return altura * comprimento;
        }

        public double getPerimetro()
        {
            return (altura * 2) + (comprimento * 2);
        }
    }
}
