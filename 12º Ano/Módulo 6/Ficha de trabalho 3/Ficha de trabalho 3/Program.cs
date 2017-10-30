using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_trabalho_3
{
    class Program
    {
        struct TemperaturaCidade
        {
            public string cidade;
            public double temperatura;

            public TemperaturaCidade(string cidade, double temperatura)
            {
                this.cidade = cidade;
                this.temperatura = temperatura;
            }
        }

        static Queue<TemperaturaCidade> temperaturaCidade;

        static void Main(string[] args)
        {
            CriarFila();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Apagar Registos.");
            Console.WriteLine("b) Verificar se registos estão vazios.");
            Console.WriteLine("c) Inserir novo registo.");
            Console.WriteLine("d) Apagar ultimo registo.");
            Console.WriteLine("e) Obter temperatura máxima.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'e')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        CriarFila();
                        break;
                    case 'b':
                        IsFilaVazia();
                        break;
                    case 'c':
                        inserirRegisto();
                        break;
                    case 'd':
                        removerRegisto();
                        break;
                    case 'e':
                        getTemperaturaMaxima();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void CriarFila()
        {
            temperaturaCidade = new Queue<TemperaturaCidade>();
            Console.WriteLine("Registos apagados com successo!");
        }

        static void IsFilaVazia()
        {
            Console.WriteLine(((temperaturaCidade.Count == 0) ? "Não " : "") + "Existem Registos!");
        }

        static void inserirRegisto()
        {
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Temperatura: ");
            double temperatura = double.Parse(Console.ReadLine());
            temperaturaCidade.Enqueue(new TemperaturaCidade(cidade, temperatura));
        }

        static void removerRegisto()
        {
            temperaturaCidade.Dequeue();
            Console.WriteLine("Registo removido!");
        }

        static void getTemperaturaMaxima()
        {
            if (temperaturaCidade.Count > 0)
            {
                TemperaturaCidade max = temperaturaCidade.Peek();
                foreach (TemperaturaCidade temp in temperaturaCidade)
                {
                    if (temp.temperatura > max.temperatura)
                    {
                        max = temp;
                    }
                }
                Console.WriteLine("Temperatura máxima foi de {0}ºC em {1}", max.temperatura, max.cidade);
            }
            else
            {
                Console.WriteLine("Não existem registos");
            }
        }
    }
}