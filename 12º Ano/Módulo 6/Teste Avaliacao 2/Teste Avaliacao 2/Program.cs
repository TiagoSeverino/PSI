using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Avaliacao_2
{
    class Program
    {
        List<Sapato> sapatos = new List<Sapato>();

        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.MainMenu();
        }

        void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Mostrar todos os sapatos");
            Console.WriteLine("2. Mostrar o número de sapatos de cada estação");
            Console.WriteLine("3. Mostrar a quantidade de sapatos número 36 de um modelo inserido pelo utilizador");
            Console.WriteLine("4. Mostrar a lista ordenada por preço");
            Console.WriteLine("5. Mostrar todos os sapatos com um preço inferior a 10 euros");
            Console.WriteLine("6. Inserir um novo sapato");
            Console.WriteLine("7. Mostrar a descrição do sapato com o código inserido pelo utilizador");
            Console.WriteLine("8. Remover um sapato por código (inserido pelo utilizador)");
            Console.WriteLine("9. Crie uma nova lista com os sapatos de ano < 2014 aplicando um desconto de 30% ao preço dos sapatos. Mostrar a lista");
            Console.WriteLine("10. Sair");

            Console.Write("Selecione uma opção:");
            int Opção = int.Parse(Console.ReadLine());

            if (Opção >= 1 && Opção <= 10)
            {
                Console.Clear();

                switch (Opção)
                {
                    case 1:
                        MostrarSapatos();
                        break;
                    case 2:
                        MostrarSapatosPorEstação();
                        break;
                    case 3:
                        MostrarSapatosPorNúmero(36);
                        break;
                    case 4:
                        MostrarPreçosOrdenados();
                        break;
                    case 5:
                        MostrarPreçoInferior(10);
                        break;
                    case 6:
                        InserirNovoSapato();
                        break;
                    case 7:
                        InserirDescrição();
                        break;
                    case 8:
                        RemoverSapato();
                        break;
                    case 9:
                        MostarAnoMenor();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        void MostrarSapatos(List<Sapato> Sapatos = null, bool MostrarEstação = true, bool TodosNúmeros = true, int Número = -1)
        {
            List<Sapato> lista;

            if (Sapatos == null)
                lista = sapatos;
            else
                lista = Sapatos;

            foreach (Sapato sapato in lista)
            {
                string desc = string.Format("Código: {0}, Nome: {1}, Modelo: {2}, Ano: {3}, Preço: {4}€", sapato.Código, sapato.Nome, sapato.Modelo, sapato.ano, sapato.preço);

                if (MostrarEstação)
                    desc += string.Format(", Estação: {0}", Estação.Nome(sapato.estação));

                if (TodosNúmeros)
                {
                    for (int i = 0; i < sapato.quantidadeTamanho.Length; i++)
                    {
                        desc += string.Format(", Quantidade de Número {0}: {1}", (i + 36), sapato.quantidadeTamanho[i]);
                    }
                }

                Console.WriteLine(desc);
            }
        }

        void MostrarSapatosPorEstação()
        {
            List<Sapato>[] estações = new List<Sapato>[4];

            estações[Estação.Verão] = sapatos.Where(item => item.estação == Estação.Verão).ToList();
            estações[Estação.Outono] = sapatos.Where(item => item.estação == Estação.Outono).ToList();
            estações[Estação.Inverno] = sapatos.Where(item => item.estação == Estação.Inverno).ToList();
            estações[Estação.Primavera] = sapatos.Where(item => item.estação == Estação.Primavera).ToList();
            
            for (int i = 0; i < estações.Length; i++)
            {
                Console.WriteLine("Estação: {0}", Estação.Nome(i));

                MostrarSapatos(estações[i], false);
            }
        }

        void MostrarSapatosPorNúmero(int número)
        {
            Console.Write("Nome do modelo: ");
            string modelo = Console.ReadLine();

            List<Sapato> Sapatos = sapatos.Where(item => item.Modelo == modelo).ToList();
            MostrarSapatos(sapatos, true, false, número);
        }

        void MostrarPreçosOrdenados()
        {
            List<Sapato> Sapatos = sapatos.OrderBy(item => item.preço).ToList();
            MostrarSapatos(Sapatos);
        }

        void MostrarPreçoInferior(double preço)
        {
            List<Sapato> Sapatos = sapatos.Where(item => item.preço < preço).ToList();
            MostrarSapatos(Sapatos);
        }

        void InserirNovoSapato()
        {
            Console.Write("Código: ");
            string Código = Console.ReadLine();

            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Modelo: ");
            string Modelo = Console.ReadLine();

            Console.WriteLine("1. Verão");
            Console.WriteLine("2. Outono");
            Console.WriteLine("3. Inverno");
            Console.WriteLine("4. Primavera");

            Console.Write("Selecione uma estação:");
            int Estação = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            double Preço = double.Parse(Console.ReadLine());

            int[] quantidade = new int[8];
            for(int i = 0; i < quantidade.Length; i++)
            {
                Console.Write("Quantidade de sapatos para o tamanho {0}: ", (i + 36));
                quantidade[i] = int.Parse(Console.ReadLine());
            }

            sapatos.Add(new Sapato
            {
                Código = Código,
                Nome = Nome,
                Modelo = Modelo,
                estação = Estação,
                ano = ano,
                preço = Preço,
                quantidadeTamanho = quantidade
            });
            Console.WriteLine("Sapato adicionado com successo!");
        }

        void InserirDescrição()
        {
            Console.Write("Código do Sapato: ");
            string Código = Console.ReadLine();

            List<Sapato> sapato = new List<Sapato>();
            sapato.Add(sapatos.First(item => item.Código == Código));

            MostrarSapatos(sapato);
        }

        void RemoverSapato()
        {
            Console.Write("Código: ");
            string Código = Console.ReadLine();

            sapatos.RemoveAll(item => item.Código == Código);
            Console.WriteLine("Sapato remocido com successo!");
        }

        void MostarAnoMenor(int ano = 2014)
        {
            List<Sapato> menor = sapatos.Where(item => item.ano < ano).ToList();

            foreach(Sapato sapato in menor)
            {
                sapato.preço *= 0.7;
            }

            MostrarSapatos(menor);
        }
    }

    class Sapato
    {
        public string Código, Nome, Modelo;
        public int estação, ano;
        public double preço;
        public int[] quantidadeTamanho;
    }

    static class Estação
    {
        public static int Verão = 0;
        public static int Outono = 1;
        public static int Inverno = 2;
        public static int Primavera = 3;

        public static string Nome(int Estação)
        {
            string estação = "";

            switch (Estação)
            {
                case 0:
                    estação = "Verão";
                    break;
                case 1:
                    estação = "Outono";
                    break;
                case 2:
                    estação = "Inverno";
                    break;
                case 3:
                    estação = "Primavera";
                    break;
            }
            return estação;
        }
    }
}
