using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    static class ListaJogadores
    {
        public static List<Rank> listaJogadores = new List<Rank>();

        public static void ordenaVitorias()
        {
            for(int i = 0; i < listaJogadores.Count; i++)
                for (int j = i + 1; j < listaJogadores.Count; j++)
                    if (listaJogadores[i].Vitorias < listaJogadores[j].Vitorias)
                    {
                        var lista = listaJogadores[j];
                        listaJogadores[j] = listaJogadores[i];
                        listaJogadores[i] = lista;
                    }

            for (int i = 0; i < listaJogadores.Count; i++)
                listaJogadores[i].posição = i + 1;
        }

        public static Rank localizaRank(int rank)
        {
            ordenaVitorias();

            if (rank <= listaJogadores.Count)
                return listaJogadores[rank];

            return null;
        }

        public static Rank localizaJogador(string nome)
        {
            foreach(Rank rank in listaJogadores)
                if (rank.jogador.Nome.ToLower().Equals(nome.ToLower()))
                    return rank;

            return null;
        }

        public static void RemoveJogador(string nome)
        {
            for (int i = 0; i < listaJogadores.Count; i++)
                if (listaJogadores[i].jogador.Nome == nome)
                {
                    Console.WriteLine("Entrou");
                    listaJogadores.RemoveAt(i);
                    return;
                }
        }

        public static void AlterarJogador(string jogador, Rank jogadorAlterado)
        {
            ordenaVitorias();

            for (int i = 0; i < listaJogadores.Count; i++)
                if (listaJogadores[i].jogador.Nome == jogador)
                {
                    listaJogadores.RemoveAt(i);
                    return;
                }

            listaJogadores.Add(jogadorAlterado);
        }
    }
}
