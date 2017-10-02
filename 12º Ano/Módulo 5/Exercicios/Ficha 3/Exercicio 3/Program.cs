using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    struct Módulo
    {
        public int Nota;

        public Módulo(int Nota)
        {
            this.Nota = Nota;
        }
    }
    struct Aluno
    {
        public string Nome;
        public Módulo[] Módulos;

        public Aluno(string Nome, Módulo[] Módulos)
        {
            this.Nome = Nome;
            this.Módulos = Módulos;
        }
    }
    class Program
    {
        static Aluno[] Alunos;
        static void Main(string[] args)
        {
            Console.Write("Número Alunos: ");
            Alunos = new Aluno[int.Parse(Console.ReadLine())];
            Console.Clear();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("a) Registar a classificação de cada módulo.");
            Console.WriteLine("b) Apresentar todas as classificações dos módulos associando a mensagem de aprovado ou reprovado.");
            Console.WriteLine("c) Pesquisar as classificações tendo por base o nome do aluno, nessa pesquisa o programa deve também apresentar a média global do aluno e a percentagem de módulos em atraso.");

            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'c')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        RegistarAluno();
                        break;
                    case 'b':
                        MostarResultados();
                        break;
                    case 'c':
                        PesquisarResultados();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void RegistarAluno()
        {
            Console.Write("Nome Aluno: ");
            string NomeAluno = Console.ReadLine();

            Console.Write("Número Módulos: ");
            Módulo[] Módulos = new Módulo[int.Parse(Console.ReadLine())];

            for (int mod = 0; mod < Módulos.Length; mod++)
            {
                Console.Write("Nota Módulo {0}: ", (mod + 1));
                Módulos[mod] = new Módulo(int.Parse(Console.ReadLine()));
            }

            int i;
            for (i = 0; i < Alunos.Length; i++)
                if (Alunos[i].Nome == null)
                    break;

            if (i < Alunos.Length)
            {
                Alunos[i] = new Aluno(NomeAluno, Módulos);
            }
        }

        static void MostarResultados()
        {
            foreach (Aluno aluno in Alunos)
            {
                if (aluno.Nome != null)
                {
                    Console.WriteLine("Nome Aluno: {0}", aluno.Nome);

                    Console.WriteLine("Número Módulos: {0}", aluno.Módulos.Length);

                    for (int mod = 0; mod < aluno.Módulos.Length; mod++)
                    {
                        Console.WriteLine("Nota Módulo {0}: {1} - {2}", (mod + 1), aluno.Módulos[mod].Nota, (aluno.Módulos[mod].Nota > 9) ? "Aprovado" : "Reprovado");
                    }

                }
            }
        }

        static void PesquisarResultados()
        {
            Console.Write("Nome Aluno: ");
            string NomeAluno = Console.ReadLine();

            foreach (Aluno aluno in Alunos)
            {
                if (aluno.Nome != null)
                {
                    if (aluno.Nome.ToLower().Contains(NomeAluno.ToLower()))
                    {
                        Console.WriteLine("Nome Aluno: {0}", aluno.Nome);

                        Console.WriteLine("Número Módulos: {0}", aluno.Módulos.Length);

                        for (int mod = 0; mod < aluno.Módulos.Length; mod++)
                        {
                            Console.WriteLine("Nota Módulo {0}: {1} - {2}", (mod + 1), aluno.Módulos[mod].Nota, (aluno.Módulos[mod].Nota > 9) ? "Aprovado" : "Reprovado");
                        }
                    }
                }
            }
        }
    }
}
