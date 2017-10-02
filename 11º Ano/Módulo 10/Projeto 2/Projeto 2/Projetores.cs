using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    [Serializable]
    static class Projetores
    {
        private static List<Projetor> projetores = new List<Projetor>();

        public static void AdicionaProjetor(string codigo, string marca, string modelo, bool isFuncional = true)
        {
            projetores.Add(new Projetor(codigo, marca, modelo, isFuncional));
        }

        public static bool AlteraProjetor(string codigo, string novoCodigo, string marca, string modelo, bool isFuncional)
        {
            for (int i = 0; i < projetores.Count; i++)
                if(projetores[i].Codigo == codigo)
                {
                    projetores.RemoveAt(i);
                    projetores.Insert(i, new Projetor(novoCodigo, marca, modelo, isFuncional));
                    return true;
                }
            return false;
        }

        public static bool EleminaProjetores(string codigo)
        {
            for (int i = 0; i < projetores.Count; i++)
                if (projetores[i].Codigo == codigo)
                {
                    projetores.RemoveAt(i);
                    return true;
                }
            return false;
        }

        public static List<Projetor> GetListProjetores()
        {
            return projetores;
        }

        public static void SetListProjetores(List<Projetor> projetor)
        {
            try
            {
                projetores = projetor;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void Novo()
        {
            projetores.Clear();
        }
    }

    [Serializable]
    public class Projetor
    {
        public string Codigo, Marca, Modelo;
        public bool IsFuncional;

        public Projetor(string codigo, string marca, string modelo, bool isFuncional = true)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            IsFuncional = isFuncional;
        }
    }
}
