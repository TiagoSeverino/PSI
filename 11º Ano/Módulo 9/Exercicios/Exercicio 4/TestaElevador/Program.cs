using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            elevador.Inicializa(50, 100);

            elevador.setPessoas(25);

            elevador.setAndar(50);

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch(rnd.Next(0, 4))
                {
                    case 0:
                        elevador.Desce();
                        break;
                    case 1:
                        elevador.Entra();
                        break;
                    case 2:
                        elevador.Sai();
                        break;
                    case 3:
                        elevador.Sobe();
                        break;
                }
            }

            elevador.Debug();

            Console.ReadLine();
        }
    }
}
