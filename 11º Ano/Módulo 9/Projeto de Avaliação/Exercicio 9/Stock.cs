using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Stock
    {
        public List<Automovel> Automoveis = new List<Automovel>();
        public List<Marca> marcas = new List<Marca>();

        public Stock()
        {

        }

        public void novoCarro(Automovel automovel)
        {
            Automoveis.Add(automovel);
        }

        public Automovel procuraCarro(string Nome)
        {
            foreach (Automovel carro in Automoveis)
                if (carro.modelo.ToLower().Equals(Nome.ToLower()))
                    return carro;

            return null;
        }

        public List<Automovel> procuraCarros(string Nome)
        {
            List<Automovel> carros = new List<Automovel>();
            foreach(Automovel carro in Automoveis)
                if (carro.modelo.ToLower().Contains(Nome.ToLower()))
                    carros.Add(carro);

            return carros;
        }

        public void updateStock(string Nome, int valor)
        {
            Automovel carro = procuraCarro(Nome);

            Automovel _carro = carro;

            _carro.stock = carro.stock + valor;

            Automoveis.Remove(carro);
            Automoveis.Add(_carro);
        }

        public bool updateVendas(string Nome, int valor)
        {
            Automovel carro = procuraCarro(Nome);

            Automovel _carro = carro;

            if (carro.stock >= valor)
            {
                _carro.vendas = carro.vendas + valor;
                _carro.stock = carro.stock - valor;

                Automoveis.Remove(carro);
                Automoveis.Add(_carro);

                return true;
            }
            return false;
        }

        public bool eleminaCarro(string Nome)
        {
            try
            {
                Automovel carro = procuraCarro(Nome);

                if (carro.modelo.ToLower().Equals(Nome.ToLower()))
                    Automoveis.Remove(carro);
                    
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string[] getMarcas()
        {
            string[] Marcas = new string[marcas.Count];

            for (int i = 0;i < marcas.Count; i++)
                Marcas[i] = marcas[i].nome;
            
            return Marcas;
        }

        public void novaMarca(string Nome, string Pais)
        {
            marcas.Add(new Marca(Nome, Pais));
        }

        public Marca procuraMarca(string Nome)
        {
            for (int i = 0; i < marcas.Count; i++)
                if (marcas[i].nome.ToLower().Contains(Nome.ToLower()))
                    return marcas[i];
            return null;
        }

        public bool eleminaMarca(string Nome)
        {
            try
            {
                marcas.Remove(procuraMarca(Nome));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
