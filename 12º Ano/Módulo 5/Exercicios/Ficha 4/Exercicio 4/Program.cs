using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static Pessoa[] Pessoas;

        struct Pessoa
        {
            public string Nome;
            public double Altura;

            public Pessoa(string Nome, double Altura)
            {
                this.Nome = Nome;
                this.Altura = Altura;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Número Pessoas: ");
            Pessoas = new Pessoa[int.Parse(Console.ReadLine())];
            Console.Clear();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Registar as alturas das pessoas.");
            Console.WriteLine("b) Apresentar os registos (nome e altura) das pessoas com altura menor ou igual a 1,5m.");
            Console.WriteLine("c) Apresentar os registos (nome e altura) das pessoas cuja altura seja maior que 1,5m.");
            Console.WriteLine("d) Apresentar os registos (nome e altura) das pessoas cuja altura seja maior que 1,5m e menor que 2,0m.");
            Console.WriteLine("e) Apresentar todos os registos indicando a média de alturas.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'e')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        RegistarPessoa();
                        break;
                    case 'b':
                        MostrarAltura(1.5, false);
                        break;
                    case 'c':
                        MostrarAltura(1.5, true);
                        break;
                    case 'd':
                        MostrarAltura(1.5, true, 2.0);
                        break;
                    case 'e':
                        MostrarAlturaMedia();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void RegistarPessoa()
        {
            Console.Write("Nome Pessoa: ");
            string NomePessoa= Console.ReadLine();

            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine().Replace('.', ','));

            int i;
            for (i = 0; i < Pessoas.Length; i++)
                if (Pessoas[i].Nome == null)
                    break;

            if (i < Pessoas.Length)
            {
                Pessoas[i] = new Pessoa(NomePessoa, Altura);
            }
        }

        static void MostrarAltura(double Valor1, bool MostrarMaior, double Valor2 = -1)
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                if (pessoa.Nome != null)
                {
                    if (MostrarMaior ? (pessoa.Altura > Valor1 && (Valor2 != -1 ? pessoa.Altura < Valor2 : true)) : (pessoa.Altura < Valor1 && (Valor2 != -1 ? pessoa.Altura > Valor2 : true)))
                    {
                        Console.WriteLine("#################################");
                        Console.WriteLine("Nome: {0}", pessoa.Nome);
                        Console.WriteLine("Altura: {0}", pessoa.Altura);
                    }
                }
            }
        }

        static void MostrarAlturaMedia()
        {
            double AlturaMédia = 0;

            int i;
            for (i = 0; i < Pessoas.Length; i++)
                if (Pessoas[i].Nome == null)
                    break;

            int TotalPessoasRegistadas = i;

            foreach (Pessoa pessoa in Pessoas)
            {
                if (pessoa.Nome != null)
                {
                    AlturaMédia += pessoa.Altura / TotalPessoasRegistadas;
                }
            }

            Console.WriteLine("Altura Média: {0}", AlturaMédia);
        }
    }
}
