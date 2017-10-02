using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Filme > filmes = new List<Filme>();

            filmes.Add(new EdicaoDoRealizador { Ano = 1999, Informação = "Lorem ipsum dolor sit amet, inceptos at a eu amet, nunc at nisl aliquip vivamus, velit urna justo, odio eget convallis corrupti bibendum", LinguagemOriginal = "Italiano", Titulo = "Lorem ipsum" });
            filmes.Add(new Filme_estrangeiro { Ano = 1999, LinguagemOriginal = "Italiano", Titulo = "Lorem ipsum", Lingua = "Portugues", PaisOrigem = "Itália" });

            foreach(Filme filme in filmes)
                Console.WriteLine(filme.mostraInformação());

            Console.ReadLine();
        }
    }
}
