using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Animal> animals = new List<Animal>();

            animals.Add(new Cão { Nome = "Boby", raça = "Pastor Suiço"});
            animals.Add(new Gato { Nome = "Gato", peso = 5.65 });
            animals.Add(new Peixe { Nome = "Tubarão", tamanho = 100 });

            foreach(Animal animal in animals)
            {
                Console.WriteLine("\n" + animal.especie + " - Nome: " + animal.Nome);
                animal.Som();
            }

            Console.ReadLine();
        }
    }
}
