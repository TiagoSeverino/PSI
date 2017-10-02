using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 
using System.IO;

namespace Projeto_2
{
    public partial class FormMenu : Form
    {
        static FormgestãoRequisições formGestãoRequisições;
        static FormGestãoProfessores formGestãoProfessores;
        static FormGestãoProjetores formGestãoProjetores;
        static FormSobre formSobre;
        static int consulta;
  
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void AbrirMenuRequisições()
        {
            formGestãoRequisições = new FormgestãoRequisições();
            formGestãoRequisições.Show();
        }

        private void AbrirMenuProfessores()
        {
            formGestãoProfessores = new FormGestãoProfessores();
            formGestãoProfessores.Show();
        }

        private void AbrirMenuProjetores()
        {
            formGestãoProjetores = new FormGestãoProjetores();
            formGestãoProjetores.Show();
        }

        private void UpdateConsulta()
        {
            Consulta(consulta);
        }

        private void Consulta(int Opção = 2)
        {
            listViewConsultas.Clear();

            consulta = Opção;

            switch (Opção)
            {
                case 0:
                    ConsultaProfessores();
                    break;

                case 1:
                    ConsultaProjetores();
                    break;

                default:
                case 2:
                    ConsultaRequisições();
                    break;
            }
        }

        private void ConsultaProjetores()
        {
            ListViewGroup listViewGroupProjetores = new ListViewGroup("Projetores");
            listViewConsultas.Groups.Add(listViewGroupProjetores);

            listViewConsultas.Columns.Add("Código", 120);
            listViewConsultas.Columns.Add("Marca", 175);
            listViewConsultas.Columns.Add("Modelo", 175);
            listViewConsultas.Columns.Add("Funciona", 120);

                CarregaProjetores(ref listViewGroupProjetores);
        }

        private void CarregaProjetores(ref ListViewGroup listViewGroupProjetores)
        {
            foreach (Projetor projetor in Projetores.GetListProjetores())
            {
                ListViewItem itemProjetor = new ListViewItem(projetor.Codigo);
                itemProjetor.SubItems.Add(projetor.Marca);
                itemProjetor.SubItems.Add(projetor.Modelo);
                itemProjetor.SubItems.Add(projetor.IsFuncional ? "Sim" : "Não");

                itemProjetor.Group = listViewGroupProjetores;

                listViewConsultas.Items.Add(itemProjetor);
            }
        }

        private void ConsultaRequisições()
        {
            ListViewGroup listViewGroupRequisições = new ListViewGroup("Requisições");
            listViewConsultas.Groups.Add(listViewGroupRequisições);

            listViewConsultas.Columns.Add("NrRequisição", 74);
            listViewConsultas.Columns.Add("NrProfessor", 74);
            listViewConsultas.Columns.Add("CodigoProjetor", 74);
            listViewConsultas.Columns.Add("DiaRequisitado", 74);
            listViewConsultas.Columns.Add("DataEntrega", 74);
            listViewConsultas.Columns.Add("DataEntregaPrevista", 74);
            listViewConsultas.Columns.Add("TempoLetivo", 74);
            listViewConsultas.Columns.Add("Entregue", 74);

            CarregaRequisições(ref listViewGroupRequisições);
        }

        private void CarregaRequisições(ref ListViewGroup listViewGroupRequisições)
        {
            foreach (Requisição requisição in Requisições.GetListRequisição())
            {
                ListViewItem itemRequisição = new ListViewItem(requisição.NrRequisição.ToString());
                itemRequisição.SubItems.Add(requisição.NrProfessor.ToString());
                itemRequisição.SubItems.Add(requisição.CodigoProjetor.ToString());
                itemRequisição.SubItems.Add(requisição.DiaRequisitado.ToShortDateString());
                itemRequisição.SubItems.Add(requisição.DataEntrega.ToShortDateString());
                itemRequisição.SubItems.Add(requisição.DataEntregaPrevista.ToShortDateString());
                itemRequisição.SubItems.Add(requisição.TempoLetivo.ToString());
                itemRequisição.SubItems.Add(requisição.IsEntregue ? "Sim" : "Não");

                itemRequisição.Group = listViewGroupRequisições;

                listViewConsultas.Items.Add(itemRequisição);
            }
        }

        private void ConsultaProfessores()
        {
            ListViewGroup listViewGroupProfessores = new ListViewGroup("Professores");
            listViewConsultas.Groups.Add(listViewGroupProfessores);

            listViewConsultas.Columns.Add("Número", 120);
            listViewConsultas.Columns.Add("Nome", 175);
            listViewConsultas.Columns.Add("Contacto", 175);
            listViewConsultas.Columns.Add("Grupo Disciplinar", 120);

            CarregaProfessores(ref listViewGroupProfessores);
        }

        private void CarregaProfessores(ref ListViewGroup listViewGroupProfessores)
        {
            foreach(Professor professor in Professores.GetListProfessores())
            {
                ListViewItem itemProfessor = new ListViewItem(professor.NrProfessor.ToString());
                itemProfessor.SubItems.Add(professor.Nome);
                itemProfessor.SubItems.Add(professor.Contacto);
                itemProfessor.SubItems.Add(professor.GrupoDisciplinar);

                itemProfessor.Group = listViewGroupProfessores;

                listViewConsultas.Items.Add(itemProfessor);
            }
        }

        public static void AbrirMenuSobre()
        {
            formSobre = new FormSobre();
            formSobre.Show();
        }

        private void Novo()
        {
            Requisições.Novo();
            Projetores.Novo();
            Professores.Novo();
            Consulta();
        }

        //Não Funciona!!!
        private void Abrir()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Requisições (*.req)|*.req";
            openFileDialog.Title = "Carregar Ficheiro";
            openFileDialog.ShowDialog();

            try
            {
                Informação informação = new Informação();

                using (Stream stream = File.Open(openFileDialog.FileName, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    informação = (Informação)bformatter.Deserialize(stream);
                }

                Professores.SetListProfessores(informação.professores);
                Projetores.SetListProjetores(informação.projetores);
                Requisições.SetListRequisição(informação.requisições);
            }
            catch
            {
                MessageBox.Show(null, "Error a Abrir o Ficheiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Guardar()
        {
            try
            {
                SaveFileDialog saveFilesDialog = new SaveFileDialog();
                saveFilesDialog.Filter = "Requisições (*.req)|*.req";
                saveFilesDialog.Title = "Gravar Ficheiro";
                saveFilesDialog.ShowDialog();

                Informação informação = new Informação()
                    {
                        professores = Professores.GetListProfessores(),
                        projetores = Projetores.GetListProjetores(),
                        requisições = Requisições.GetListRequisição()
                    };

                using (Stream stream = File.Open(saveFilesDialog.FileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, informação);
                }
            }
            catch
            {
                MessageBox.Show(null, "Error A Gravar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sair()
        {
            Environment.Exit(0);
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMenuSobre();
        }

        private void ProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMenuProfessores();
        }

        private void ProjetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMenuProjetores();
        }

        private void RequisiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMenuRequisições();
        }

        private void ProfessoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta(0);
        }

        private void ProjetoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta(1);
        }

        private void RequisiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta(2);
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }

    [Serializable]
    public class Informação
    {
        public List<Professor> professores;
        public List<Projetor> projetores;
        public List<Requisição> requisições;
    }
}
