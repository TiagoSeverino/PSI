using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static Produto[] Produtos;

        struct Produto
        {
            public string Descrição;
            public double Valor;

            public Produto(string Descrição, double Valor)
            {
                this.Descrição = Descrição;
                this.Valor= Valor;
            }
        }

        static void Main(string[] args)
        {

            Produtos = new Produto[5];

            for (int i = 0; i < Produtos.Length; i++)
            {
                Console.Write("Descrição Produto: ");
                string Descrição = Console.ReadLine();

                Console.Write("Valor: ");
                double Valor = double.Parse(Console.ReadLine().Replace('.', ','));

                Produtos[i] = new Produto(Descrição, Valor);

                Console.Clear();
            }

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("1) Exibir produtos na ordem inversa em que foram digitados;");
            Console.WriteLine("2) Mostre o produto mais caro e o mais barato da loja.");

            Console.Write("Selecione uma opção: ");
            char Opção = Console.ReadLine().ToLower()[0];

            if (Opção >= '1' & Opção <= '2')
            {
                Console.Clear();

                switch (Opção)
                {
                    case '1':
                        MostrarOdemInversa();
                        break;
                    case '2':
                        MostrarPreçoDescendente();
                        break;
                }
                Console.ReadLine();
            }
            MainMenu();
        }

        static void MostrarOdemInversa()
        {
            for(int i = Produtos.Length - 1; i >= 0; i--)
            {
                Console.Write("\n");
                Console.WriteLine("Descrição: {0}", Produtos[i].Descrição);
                Console.WriteLine("Valor: {0}", Produtos[i].Valor);
            }
        }

        static void MostrarPreçoDescendente()
        {
            Produto[] ProdutosPreçoDescendente = Produtos.OrderBy(item => item.Valor).ToArray();

            for (int i = ProdutosPreçoDescendente.Length - 1; i >= 0; i--)
            {
                Console.Write("\n");
                Console.WriteLine("Descrição: {0}", ProdutosPreçoDescendente[i].Descrição);
                Console.WriteLine("Valor: {0}", ProdutosPreçoDescendente[i].Valor);
            }
        }
    }
}
