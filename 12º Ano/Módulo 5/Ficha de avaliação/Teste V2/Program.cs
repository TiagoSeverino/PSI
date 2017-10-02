using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_V2
{
    class Program
    {
        static List<Produto> Produtos = new List<Produto>();
        static List<Cartão> Cartões = new List<Cartão>();
        static List<Pagamento> Pagamentos = new List<Pagamento>();

        static int NúmeroCartão = 1;

        struct Produto
        {
            public string CódigoProduto;
            public string Descrição;
            public double Preço;

            public Produto(string CódigoProduto, string Descrição, double Preço)
            {
                this.CódigoProduto = CódigoProduto;
                this.Descrição = Descrição;
                this.Preço = Preço;
            }
        }

        struct Cartão
        {
            public Produto[] Produtos;
            public int ID;

            public Cartão(ref int NúmeroCartão)
            {
                Produtos = new Produto[10];

                ID = NúmeroCartão;
                NúmeroCartão++;
            }
        }

        struct Pagamento
        {

        }

        static void Main(string[] args)
        {
            CarregaVariaveis();
            MainMenu();
        }

        static void CarregaVariaveis()
        {
            Produtos.Add(new Produto("1", "Cerveja", 1));
            Produtos.Add(new Produto("2", "Shot", 1.5));
            Produtos.Add(new Produto("3", "Sandes", 2));
            Produtos.Add(new Produto("4", "Iced Tea", 1.5));
            Produtos.Add(new Produto("5", "Sumo Laranja", 1.5));
            Produtos.Add(new Produto("6", "Vodka", 3));
            Produtos.Add(new Produto("7", "2x Shots", 1.8));
            Produtos.Add(new Produto("8", "5x Shots", 4));
            Produtos.Add(new Produto("9", "10x Shots", 7.5));
            Produtos.Add(new Produto("10", "20x Shots", 14));
            Produtos.Add(new Produto("11", "30x Shots", 20));

            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));
            Cartões.Add(new Cartão(ref NúmeroCartão));

            int i = 0;
            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);

            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);

            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);

            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);

            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);

            i++;
            AdicionaProduto(i, Produtos[0]);
            AdicionaProduto(i, Produtos[1]);
            AdicionaProduto(i, Produtos[2]);
            AdicionaProduto(i, Produtos[3]);
            AdicionaProduto(i, Produtos[4]);
            AdicionaProduto(i, Produtos[5]);
            AdicionaProduto(i, Produtos[6]);
        }

        static void AdicionaProduto(int IDCartão, Produto produto)
        {
            foreach (Cartão cartão in Cartões)
            {
                if (cartão.Produtos != null && cartão.ID == IDCartão)
                    for (int i = 0; i < cartão.Produtos.Length; i++)
                    {
                        if (cartão.Produtos[i].Descrição == null)
                        {
                            cartão.Produtos[i] = produto;
                            return;
                        }
                    }
            }
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.Title = "Gestão de Cartões de uma Discoteca";

            Console.WriteLine("a) Descrição do Produto");
            Console.WriteLine("b) Total do Cartão");
            Console.WriteLine("c) Total de todos os Cartões.");

            Console.Write("Selecione uma opção: ");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= 'a' & Opção <= 'c')
            {
                Console.Clear();

                switch (Opção)
                {
                    case 'a':
                        DescriçãoProduto();
                        break;
                    case 'b':
                        TotalCartão();
                        break;
                    case 'c':
                        MostrarCartões();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void DescriçãoProduto()
        {
            Console.Title = "Descrição Produto";

            Console.Write("Codigo do Produto: ");
            string Código = Console.ReadLine();

            Produto produto = Produtos.Find(item => item.CódigoProduto == Código);

            if (produto.CódigoProduto == null)
            {
                Console.WriteLine("Produto Não Encontrado");
                return;
            }

            MostrarProduto(produto);
        }

        static void MostrarProduto(Produto produto)
        {
            Console.WriteLine("Código Produto: {0}", produto.CódigoProduto);
            Console.WriteLine("Descrição: {0}", produto.Descrição);
            Console.WriteLine("Preço: {0}", produto.Preço);
        }

        static void TotalCartão()
        {
            Console.Title = "Total Cartão";

            Console.Write("Número do Cartão: ");
            int IDCartão = int.Parse(Console.ReadLine());

            MostrarCartão(IDCartão);
        }

        static void MostrarCartões()
        {
            Console.Title = "Total Cartões";

            foreach (Cartão cartão in Cartões)
            {
                if (cartão.Produtos[0].Descrição != null)
                    MostrarCartão(cartão.ID);
            }
        }

        static void MostrarCartão(int IDCartão)
        {
            Console.WriteLine("Cartão: {0}", IDCartão);

            Cartão cartão = Cartões.Find(item => item.ID == IDCartão);

            if (cartão.Produtos != null)
            {
                double PreçoTotal = 0;

                foreach (Produto produto in cartão.Produtos)
                {
                    if (produto.CódigoProduto != null)
                    {
                        Console.Write("\n");
                        MostrarProduto(produto);
                        PreçoTotal += produto.Preço;
                    }
                }

                Console.WriteLine("\nTotal: {0}", PreçoTotal);

                return;
            }

            Console.WriteLine("Cartão Não Encontrado");
        }
    }
}
