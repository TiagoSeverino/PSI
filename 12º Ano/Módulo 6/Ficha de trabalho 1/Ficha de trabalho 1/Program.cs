using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_trabalho_1
{
    class Program
    {
        struct Avião
        {
            public string Nome;
            public int Número;

            public Avião(string Nome, int Número)
            {
                this.Nome = Nome;
                this.Número = Número;
            }
        }

        static Queue<Avião> filaDescolagem;

        static void Main(string[] args)
        {
            filaDescolagem = new Queue<Avião>();

            filaDescolagem.Enqueue(new Avião("Boeing 747", 747));
            filaDescolagem.Enqueue(new Avião("Boeing 777", 777));
            filaDescolagem.Enqueue(new Avião("Airbus A380", 380));

            Console.WriteLine(filaDescolagem.Peek().Nome + " Autorizado a Descolar");
            filaDescolagem.Dequeue();

            filaDescolagem.Enqueue(new Avião("Boeing 666", 666));

            Console.WriteLine("Fila de Descolagem:");
            foreach (Avião avião in filaDescolagem)
            {
                Console.WriteLine("\t{0}: {1}", avião.Nome, avião.Número);
            }

            Avião primeiro = filaDescolagem.Peek();
            Console.WriteLine("Primeiro avião da fila é um {0}, número {1}", primeiro.Nome, primeiro.Número);

            Console.ReadLine();
        }
    }
}
