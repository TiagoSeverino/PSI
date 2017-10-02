using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_Avalicação
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Inicio();
        }

        public void Inicio()
        {
            Corrida corrida = new Corrida();

            corrida.nrCorrida = 52;
            corrida.localCorrida = "Torres Vedras";
            corrida.MaxCarros = 9;
            corrida.dataCorrida = DateTime.Now;

            List<Piloto> pilotos = new List<Piloto>();
            List<Carro> carros = new List<Carro>();
            List<Equipa> equipas = new List<Equipa>();

            for (int i = 0; i < 9; i++)
            {
                pilotos.Add(new Piloto());

                pilotos[i].nome = "AVDSAVA";
                pilotos[i].idade = (int)(new Random().NextDouble() * 100);
                pilotos[i].peso = new Random().NextDouble() * 100;
                pilotos[i].altura = new Random().NextDouble() * 100;
                pilotos[i].sexo = new Random().NextDouble() > 0.5 ? "Masculino" : "Feminino";

                carros.Add(new Carro());

                carros[i].marca = "Citroen";
                carros[i].modelo = "C4";
                carros[i].piloto = pilotos[i];

                corrida.adicionarCarro(carros[i]);
            }

            for(int i = 0; i < 3; i++)
            {
                equipas.Add(new Equipa(carros[i*3], carros[i*3+1], carros[i*3+2]));
            }

            equipas[0].nome = "Benfica";
            equipas[1].nome = "Sporting";
            equipas[2].nome = "Porto";

            Pontuações pontuacoes = new Pontuações();
            pontuacoes.corrida = corrida;

            for (int i = 0; i < equipas.Count; i++)
            {
                pontuacoes.equipa.Add(equipas[i]);
            }

            pontuacoes.pontuacao.Add(34);
            pontuacoes.pontuacao.Add(21);
            pontuacoes.pontuacao.Add(42);

            pontuacoes.verData();
            pontuacoes.verLocal();
            pontuacoes.verNrCarrosParticipantes();
            pontuacoes.verNumeroCorrida();
            pontuacoes.verPontuacao();

            Console.ReadLine();
        }
    }
}
