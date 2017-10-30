using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_trabalho_2
{
    class Program
    {
        struct DadoAluno
        {
            public string nome;
            public int anoDisciplina;
            public double classificaçao;

            public DadoAluno(string nome, int anoDisciplina, double classificaçao)
            {
                this.nome = nome;
                this.anoDisciplina = anoDisciplina;
                this.classificaçao = classificaçao;
            }
        }

        static Stack<DadoAluno> dadosAlunos;

        static void Main(string[] args)
        {
            CriarPilha();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("a) Apagar Registos.");
            Console.WriteLine("b) Verificar se registos estão vazios.");
            Console.WriteLine("c) Inserir novo registo.");
            Console.WriteLine("d) Apagar ultimo registo.");
            Console.WriteLine("e) Verificar classificação do aluno.");

            Console.Write("Selecione uma opção:");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'e')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        CriarPilha();
                        break;
                    case 'b':
                        IsPilhaVazia();
                        break;
                    case 'c':
                        inserirRegisto();
                        break;
                    case 'd':
                        removerRegisto();
                        break;
                    case 'e':
                        getClassificação();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void CriarPilha()
        {
            dadosAlunos = new Stack<DadoAluno>();
            Console.WriteLine("Registos apagados com successo!");
        }

        static void IsPilhaVazia()
        {
            Console.WriteLine(((dadosAlunos.Count == 0) ? "Não " : "") + "Existem Registos!");
        }

        static void inserirRegisto()
        {
            Console.Write("Nome Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Ano Disciplina: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Classificação: ");
            double classificaçao = double.Parse(Console.ReadLine());
            dadosAlunos.Push(new DadoAluno(nome, ano, classificaçao));
        }

        static void removerRegisto()
        {
            dadosAlunos.Pop();
            Console.WriteLine("Registo removido!");
        }

        static void getClassificação()
        {
            Console.Write("Nome Aluno: ");
            string nome = Console.ReadLine();

            foreach (DadoAluno aluno in dadosAlunos)
            {
                if (aluno.nome == nome)
                {
                    Console.WriteLine("A nota do {0}, foi {1}", aluno.nome, aluno.classificaçao);
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado");
        }
    }
}
