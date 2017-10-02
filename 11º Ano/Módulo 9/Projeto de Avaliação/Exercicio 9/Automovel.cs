using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Automovel
    {
        public Marca marca { get; set; }
        public string modelo { get; set; }
        public double preco { get; set; }
        public string cor { get; set; }
        public double zeroCem { get; set; }
        public double consumo { get; set; }
        public string extras { get; set; }
        public int stock { get; set; }
        public int vendas { get; set; }

        public Automovel(Marca Marca, string Modelo, double Preco, string Cor, double ZeroCem, double Consumo, string Extras, int Stock, int Vendas)
        {
            marca = Marca;
            modelo = Modelo;
            preco = Preco;
            cor = Cor;
            zeroCem = ZeroCem;
            consumo = Consumo;
            extras = Extras;
            stock = Stock;
            vendas = Vendas;
        }

        public void adicionaStock(int Stock)
        {
            stock += Stock;
        }

        public void vender()
        {
            if (stock > 0)
            {
                stock--;
                vendas++;
            }
        }
    }
}
