using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    class Program
    {
        struct Carro
        {
            public string matricula;
            public string marca;
            public string modelo;
            public string cor;
            public string combustivel;

            public Carro(string matricula, string marca, string modelo, string cor, string combustivel)
            {
                this.matricula = matricula;
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
                this.combustivel = combustivel;
            }
        }

        static void Main(string[] args)
        {
            Stack<Carro> Carros = new Stack<Carro>();

            
            Carros.Push(new Carro("20-AC-0A", "Land Rover", "Range Rover", "verde", "gasoleo"));
            Carros.Push(new Carro("20-AC-0A", "Land Rover", "Range Rover", "rosa", "gasoleo"));
            Carros.Push(new Carro("20-AC-0A", "Land Rover", "Range Rover", "azul", "gasoleo"));
            Carros.Push(new Carro("20-AC-0A", "Land Rover", "Range Rover", "verde", "gasoleo"));
            Carros.Push(new Carro("20-AC-0A", "Land Rover", "Range Rover", "vermelho", "gasoleo"));

            int verdes = 0;

            foreach (Carro carro in Carros)
                if (carro.cor == "verde")
                    verdes++;

            Console.WriteLine("Existem {0} carro/s verdes", verdes);

            Carros.Pop();
            Carros.Pop();
            Carros.Pop();

            Carro rosa = Carros.Peek();
            Console.WriteLine("Matricula: {0}, Marca: {1}, Modelo: {2}, Cor: {3}, Combustivel: {4}", rosa.matricula, rosa.marca, rosa.modelo, rosa.cor, rosa.combustivel);

            Carros.Pop();
            Carros.Pop();

            Console.ReadLine();
        }
    }
}
