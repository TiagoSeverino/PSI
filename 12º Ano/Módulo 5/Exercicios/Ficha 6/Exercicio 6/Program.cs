using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static Pessoa[] Pessoas;

        struct Pessoa
        {
            public string Nome;
            public int Idade;
            public bool? IsHomem;
            public bool? IsSaúdavel;

            public Pessoa(string Nome, bool? IsHomem, int Idade, bool? IsSaúdavel)
            {
                this.Nome = Nome;
                this.IsHomem = IsHomem;
                this.Idade = Idade;
                this.IsSaúdavel = IsSaúdavel;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Número de pessoas: ");
            Pessoas = new Pessoa[int.Parse(Console.ReadLine())];
            Console.Clear();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Registar pessoa.");
            Console.WriteLine("b) Mostar Estatisticas.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'b')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        RegistarPessoa();
                        break;
                    case 'b':
                        MostrarEstatisticas();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void RegistarPessoa()
        {
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Idade: ");
            int Idade = int.Parse(Console.ReadLine());

            bool? IsHomem = null;
            bool? IsSaúdavel = null;

            while (!IsHomem.HasValue)
            {
                Console.WriteLine("a) Masculino.");
                Console.WriteLine("b) Feminino.");
                Console.Write("Selecione o sexo: ");

                switch (Console.ReadLine().ToLower()[0])
                {
                    case 'a':
                        IsHomem = true;
                        break;
                    case 'b':
                        IsHomem = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            while (!IsSaúdavel.HasValue)
            {
                Console.WriteLine("a) Saúdavel.");
                Console.WriteLine("b) Não Saúdavel.");
                Console.Write("Selecione o estado de saúde: ");

                switch (Console.ReadLine().ToLower()[0])
                {
                    case 'a':
                        IsSaúdavel = true;
                        break;
                    case 'b':
                        IsSaúdavel = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            int i;
            for (i = 0; i < Pessoas.Length; i++)
                if (Pessoas[i].Nome == null)
                    break;

            if (i < Pessoas.Length)
            {
                Pessoas[i] = new Pessoa(Nome, IsHomem, Idade, IsSaúdavel);
                Console.WriteLine((Idade > 18 && IsSaúdavel == true) ? "Apto para cumprir serviço militar obrigatório" : "Não apto para cumprir serviço militar obrigatório");
            }
        }

        static void MostrarEstatisticas()
        {
            int TotalPessoas = 0;
            int AptosServiçoMilitarObrigatório = 0;
            int Homems = 0;
            int Saúdaveis = 0;
            int SomaIdades = 0;
            double MédiaIdades = 0;
            int? IdadeMinima = null;
            int? IdadeMáxima = null;

            foreach (Pessoa pessoa in Pessoas)
            {
                if (pessoa.Nome != null)
                {
                    TotalPessoas++;
                    SomaIdades += pessoa.Idade;

                    if (IdadeMinima == null || pessoa.Idade < IdadeMinima)
                        IdadeMinima = pessoa.Idade;

                    if (IdadeMáxima == null || pessoa.Idade > IdadeMáxima)
                        IdadeMáxima = pessoa.Idade;

                    if (pessoa.IsHomem.Value == true)
                        Homems++;

                    if (pessoa.IsSaúdavel.Value == true)
                        Saúdaveis++;

                    if (pessoa.Idade > 18 && pessoa.IsSaúdavel.Value == true)
                        AptosServiçoMilitarObrigatório++;
                }
            }

            if (TotalPessoas == 0)
            {
                Console.WriteLine("Não existem pessoas registadas");
            }
            else
            {
                MédiaIdades = SomaIdades / TotalPessoas;
                int Mulheres = TotalPessoas - Homems;
                int NãoSaúdaveis = TotalPessoas - Saúdaveis;
                int NãoAptosServiçoMilitarObrigatório = TotalPessoas - AptosServiçoMilitarObrigatório;

                Console.WriteLine("Total Pessoas: {0}", TotalPessoas);
                Console.WriteLine("Pessoas aptas para serviço militar obrigatório: {0}", AptosServiçoMilitarObrigatório);
                MostrarPercentagem(AptosServiçoMilitarObrigatório, TotalPessoas);

                Console.WriteLine("Pessoas não aptas para serviço militar obrigatório: {0}", NãoAptosServiçoMilitarObrigatório);
                MostrarPercentagem(NãoAptosServiçoMilitarObrigatório, TotalPessoas);

                Console.WriteLine("Total Homens: {0}", Homems, Homems);
                MostrarPercentagem(Homems, TotalPessoas);

                Console.WriteLine("Total Mulheres: {0}", Mulheres);
                MostrarPercentagem(Mulheres, TotalPessoas);

                Console.WriteLine("Total Saúdaveis: {0}", Saúdaveis);
                MostrarPercentagem(Saúdaveis, TotalPessoas);

                Console.WriteLine("Total Não Saúdaveis: {0}", NãoSaúdaveis);
                MostrarPercentagem(NãoSaúdaveis, TotalPessoas);

                Console.WriteLine("Média Idades: {0}", MédiaIdades);
                Console.WriteLine("Idade Mais Baixa: {0}", IdadeMinima);
                Console.WriteLine("Idade Mais Alta: {0}", IdadeMáxima);
            }
        }

        static void MostrarPercentagem(int Valor, int Total)
        {
            double TamanhoBarra = 60.0;
            double Divisor = Total / TamanhoBarra;
            int Valor1 = (int) (Valor / Divisor);

            for (int i = 0; i < TamanhoBarra; i++)
            {
                Console.Write((i < Valor1) ? "#" : "-");
            }

            Console.Write(" ({0}%)", (int)((Valor * 1.0) / (Total* 1.0) * 100.0));
            Console.WriteLine("\n");
        }
    }
}