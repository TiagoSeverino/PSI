using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static Funcionário[] Funcionários;

        struct Funcionário
        {
            public string Nome;
            public int NúmeroFuncionário;
            public double Salário;

            public Funcionário(string Nome, int NúmeroFuncionário, double Salário)
            {
                this.Nome = Nome;
                this.NúmeroFuncionário = NúmeroFuncionário;
                this.Salário = Salário;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Número de funcionários: ");
            Funcionários = new Funcionário[int.Parse(Console.ReadLine())];
            Console.Clear();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Registar os empregados.");
            Console.WriteLine("b) Ordenar os registos por número de funcionário.");
            Console.WriteLine("c) Pesquisar um determinado empregado pelo número de funcionário.");
            Console.WriteLine("d) Apresentar de forma ordenada os registos dos empregados que recebem salários acima de 1.000€.");
            Console.WriteLine("e) Apresentar de forma ordenada os registos dos empregados que recebem salários abaixo de 500€.");
            Console.WriteLine("f) Apresentar de forma ordenada os registos dos empregados que recebem salários acima da média de salários.");
            Console.WriteLine("g) Apresentar todos os funcionários.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'g')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        RegistarEmpregados();
                        break;
                    case 'b':
                        OrdenarRegistos();
                        break;
                    case 'c':
                        Console.Write("Número Funcionário: ");
                        PesquisarFuncionário(int.Parse(Console.ReadLine()), false, true);
                        break;
                    case 'd':
                        PesquisarFuncionário(1000, true);
                        break;
                    case 'e':
                        PesquisarFuncionário(5000, false);
                        break;
                    case 'f':
                        PesquisarFuncionário(GetMedia(), true);
                        break;
                    case 'g':
                        PesquisarFuncionário(0, true);
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void RegistarEmpregados()
        {
            Console.Write("Nome Empregado: ");
            string NomeEmpregado = Console.ReadLine();

            Console.Write("Número Funcionário: ");
            int NúmeroFuncionário = int.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            double Salário = double.Parse(Console.ReadLine().Replace('.', ','));

            int i;
            for (i = 0; i < Funcionários.Length; i++)
                if (Funcionários[i].Nome == null)
                    break;

            if (i < Funcionários.Length)
            {
                Funcionários[i] = new Funcionário(NomeEmpregado, NúmeroFuncionário, Salário);
            }
        }

        static void OrdenarRegistos()
        {
            Funcionários = Funcionários.OrderBy(item => item.NúmeroFuncionário).ToArray();
            Console.WriteLine("Ordenado com sucesso!");
        }

        static void PesquisarFuncionário(double Valor1, bool MostrarMaior, bool ProcurarNúmero = false)
        {
            int i = 0;
            foreach (Funcionário funcionário in Funcionários)
            {
                if (funcionário.Nome != null)
                {
                    if (ProcurarNúmero ? (funcionário.NúmeroFuncionário == Valor1) :  (MostrarMaior ? (funcionário.Salário > Valor1) : (funcionário.Salário < Valor1)))
                    {
                        i++;
                        Console.WriteLine("################################");
                        Console.WriteLine("Nome: {0}", funcionário.Nome);
                        Console.WriteLine("Número Funcionário: {0}", funcionário.NúmeroFuncionário);
                        Console.WriteLine("Salário: {0}", funcionário.Salário);
                    }
                }
            }

            if (i == 0)
            {
                Console.WriteLine("Funcionário/s Não Encontrado");
            }
        }

        static double GetMedia()
        {
            int i = 0;
            double SomaSalários = 0;
            foreach (Funcionário funcionário in Funcionários)
                if (funcionário.Nome != null)
                {
                    i++;
                    SomaSalários += funcionário.Salário;
                }
            return SomaSalários/i;
        }
    }
}
