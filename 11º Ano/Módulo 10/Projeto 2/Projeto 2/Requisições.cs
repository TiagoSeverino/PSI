using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    [Serializable]
    static class Requisições
    {
        private static List<Requisição> requisições = new List<Requisição>();
        private static int NúmeroRequisição = 0;

        private static int NrRequisição()
        {
            NúmeroRequisição++;
            return NúmeroRequisição;
        }

        public static void AdicionaRegisto(int NrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo)
        {
            requisições.Add(new Requisição(NrRequisição(), NrProfessor, codigoProjetor, diaRequisitado, tempoLetivo));
        }

        public static void AdicionaRegisto(int NrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo, bool isEntregue, DateTime dataEntrega)
        {
            requisições.Add(new Requisição(NrRequisição(), NrProfessor, codigoProjetor, diaRequisitado, tempoLetivo, isEntregue, dataEntrega));

        }

        public static bool AlteraRegisto(int NrRequisição, int NrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo)
        {
            if (NrRequisição < NúmeroRequisição)
                for (int i = 0; i < requisições.Count; i++)
                    if (NrRequisição == requisições[i].NrRequisição)
                    {
                        requisições.RemoveAt(i);
                        requisições.Insert(i, new Requisição(NrRequisição, NrProfessor, codigoProjetor, diaRequisitado, tempoLetivo));
                        return true;
                    }
            return false;
        }

        public static bool AlteraRegisto(int NrRequisição, int NrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo, bool isEntregue, DateTime dataEntrega)
        {
            if (NrRequisição < NúmeroRequisição)
                for(int i = 0; i < requisições.Count; i++)
                    if (NrRequisição == requisições[i].NrRequisição)
                    {
                        requisições.RemoveAt(i);
                        requisições.Insert(i, new Requisição(NrRequisição, NrProfessor, codigoProjetor, diaRequisitado, tempoLetivo, isEntregue, dataEntrega));
                        return true;
                    }
            return false;
        }

        public static bool EleminaRegistos(int NrRequisição)
        {
            if(NrRequisição <= NúmeroRequisição)
                for(int i = 0; i < requisições.Count; i++)
                    if (requisições[i].NrRequisição == NrRequisição)
                    {
                        requisições.RemoveAt(i);
                        return true;
                    }
            return false;
        }

        public static List<Requisição> GetListRequisição()
        {
            return requisições;
        }

        public static void SetListRequisição(List<Requisição> requisição)
        {
            try
            {
                requisições = requisição;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void Novo()
        {
            requisições.Clear();
            NúmeroRequisição = 0;
        }

        public static void OrdenaDataEntrega()
        {
            for (int i = 0; i < requisições.Count; i++)
                for (int j = i + 1; j < requisições.Count; j++)
                    if (requisições[i].DataEntrega < requisições[j].DataEntrega)
                    {
                        var lista = requisições[j];
                        requisições[j] = requisições[i];
                        requisições[i] = lista;
                    }
        }
    }

    [Serializable]
    public class Requisição
    {
        public int NrRequisição, NrProfessor;
        public string CodigoProjetor;
        public DateTime DiaRequisitado, DataEntrega, DataEntregaPrevista;
        public int TempoLetivo;
        public bool IsEntregue;

        public Requisição(int nrRequisição, int nrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo)
        {
            NrRequisição = nrRequisição;
            NrProfessor = nrProfessor;
            CodigoProjetor = codigoProjetor;
            TempoLetivo = tempoLetivo;
            DiaRequisitado = diaRequisitado;
            DataEntregaPrevista = DiaRequisitado.Add(TimeSpan.FromDays(TempoLetivo));

            IsEntregue = false;
        }

        public Requisição(int nrRequisição, int nrProfessor, string codigoProjetor, DateTime diaRequisitado, int tempoLetivo, bool isEntregue, DateTime dataEntrega)
        {
            NrRequisição = nrRequisição;
            NrProfessor = nrProfessor;
            CodigoProjetor = codigoProjetor;
            TempoLetivo = tempoLetivo;
            DiaRequisitado = diaRequisitado;
            DataEntregaPrevista = DiaRequisitado.Add(TimeSpan.FromDays(TempoLetivo));

            IsEntregue = isEntregue;

            if (IsEntregue)
                DataEntrega = dataEntrega;
        }
    }
}
