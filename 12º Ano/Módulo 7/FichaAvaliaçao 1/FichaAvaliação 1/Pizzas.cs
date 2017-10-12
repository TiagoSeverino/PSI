using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaAvaliação_1
{
    static class Pizzas
    {
        public static List<Pizza> ListaPizzas = new List<Pizza>();
        public static List<VendaPizzas> ListaVendaPizzas = new List<VendaPizzas>();

        [Serializable]
        public struct Pizza
        {
            public string Nome;
            public string Ingrediente1;
            public string Ingrediente2;
            public string Ingrediente3;
            public string Ingrediente4;
            public string Ingrediente5;
            public Image Imagem;

            public Pizza(string Nome, string Ingrediente1, string Ingrediente2, string Ingrediente3, string Ingrediente4, string Ingrediente5, Image Imagem)
            {
                this.Nome = Nome;
                this.Ingrediente1 = Ingrediente1;
                this.Ingrediente2 = Ingrediente2;
                this.Ingrediente3 = Ingrediente3;
                this.Ingrediente4 = Ingrediente4;
                this.Ingrediente5 = Ingrediente5;
                this.Imagem = Imagem;
            }
        }

        [Serializable]
        public struct VendaPizzas
        {
            public DateTime Data;
            public string NomePizza;
            public int Quantidade;

            public VendaPizzas(DateTime Data, string NomePizza, int Quantidade)
            {
                this.Data = Data;
                this.NomePizza = NomePizza;
                this.Quantidade = Quantidade;

            }
        }
    }
}
