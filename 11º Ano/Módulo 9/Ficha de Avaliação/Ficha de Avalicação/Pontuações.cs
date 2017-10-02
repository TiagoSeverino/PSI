using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_Avalicação
{
    class Pontuações
    {
        public Corrida corrida { get; set; }
        public List<Equipa> equipa { get; set; } = new List<Equipa>();
        public List<int> pontuacao { get; set; } = new List<int>();

        public void verNumeroCorrida()
        {
            Console.WriteLine("Número da Corrida: {0}", corrida.nrCorrida);
        }

        public void verData()
        {
            Console.WriteLine("Data da Corrida: {0}", corrida.dataCorrida.ToShortTimeString());
        }

        public void verLocal()
        {
            Console.WriteLine("Local da Corrida: {0}", corrida.localCorrida);
        }

        public void verNrCarrosParticipantes()
        {
            Console.WriteLine("Número de Carros Participantes: {0}", corrida.nrCarros);
        }

        public void verPontuacao()
        {
            int vencedora = 0;
            for(int i = 0; i < equipa.Count; i++)
            {
                if (pontuacao[i] > pontuacao[vencedora])
                    vencedora = i;
                Console.WriteLine("Pontuacao do {0}: {1}", equipa[i].nome, pontuacao[i]);
            }

            Console.WriteLine("\nEquipa Vencedora: {0} com a pontuação de: {1} Pontos", equipa[vencedora].nome, pontuacao[vencedora]);
            
        }
    }
}
