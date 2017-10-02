using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    [Serializable]
    static class Professores
    {
        private static List<Professor> professores = new List<Professor>();

        private static int NúmerorProfessor = 0;

        private static int NrProfessor()
        {
            NúmerorProfessor++;
            return NúmerorProfessor;
        }

        public static void AdicionaProfessor(string nome, string contacto, string grupoDisciplinar)
        {
            professores.Add(new Professor(NrProfessor(), nome, contacto, grupoDisciplinar));
        }

        public static bool AlteraProfessor(string nome, string contacto, string grupoDisciplinar, int nrProfessor)
        {
            if (nrProfessor <= NúmerorProfessor && nrProfessor > 0)
            {
                professores.RemoveAt(nrProfessor - 1);
                professores.Insert(nrProfessor - 1, new Professor(nrProfessor, nome, contacto, grupoDisciplinar));
                return true;
            }
            return false;
        }

        public static bool EleminaProfessor(int nrProfessor)
        {
            for (int i = 0; i < professores.Count; i++)
                if (professores[i].NrProfessor == nrProfessor)
                {
                    professores.RemoveAt(i);
                    return true;
                }
            return false;
        }

        public static List<Professor> GetListProfessores()
        {
            return professores;
        }

        public static void SetListProfessores(List<Professor> Professores)
        {
            try
            {
                professores = Professores;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void Novo()
        {
            professores.Clear();
            NúmerorProfessor = 0;
        }
    }

    [Serializable]
    public class Professor
    {
        public int NrProfessor;
        public string Nome, Contacto, GrupoDisciplinar;

        public Professor(int nrProfessor, string nome, string contacto, string grupoDisciplinar)
        {
            NrProfessor = nrProfessor;
            Nome = nome;
            Contacto = contacto;
            GrupoDisciplinar = grupoDisciplinar;
        }
    }
}
