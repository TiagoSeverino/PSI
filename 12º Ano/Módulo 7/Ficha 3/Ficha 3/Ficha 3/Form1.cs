using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_3
{
    public partial class FormMainMenu : Form
    {
        bool Guardado;
        string NomeFicheiro;
        string DiretórioFicheiro;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;

        BinaryFormatter formatter;

        List<Contacto> Contactos;

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contactos = new List<Contacto>();

            string Filtro = "Agenda (*.agd)|*.agd|Todos os ficheiros (*.*)|*.*";

            openFileDialog = new OpenFileDialog
            {
                Filter = Filtro,
                RestoreDirectory = true,
                Multiselect = false
            };
            saveFileDialog = new SaveFileDialog
            {
                Filter = Filtro,
                RestoreDirectory = true
            };

            formatter = new BinaryFormatter();
            
            Guardado = true;
            NomeFicheiro = "Nova Agenda";

            AtualizarTitulo();

            Contactos.Add(new Contacto("Tiago", "asda", "321312", "sdda", "dasdas", "dsaasa"));
        }

        #region Eventos

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoFicheiro();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFicheiro();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarFicheiro();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        #endregion

        #region Funções
        private void AtualizarTitulo()
        {
            this.Text = (Guardado ? "" : "* ") + NomeFicheiro + " - Agenda";
        }

        private void NovoFicheiro()
        {
            if (!ConfirmaNovoDocumento())
                return;

            Contactos = new List<Contacto>();

            NomeFicheiro = "Nova Agenda";
            DiretórioFicheiro = null;
            Guardado = true;

            AtualizarTitulo();
        }

        private void AbrirFicheiro()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(DiretórioFicheiro, FileMode.Open);

                try
                {
                    Contactos = ((Contacto[]) formatter.Deserialize(fs)).OfType<Contacto>().ToList();

                    DiretórioFicheiro = openFileDialog.FileName;
                    string[] DiretóriosFicheiro = DiretórioFicheiro.Split('\\'); ;
                    NomeFicheiro = DiretóriosFicheiro[DiretóriosFicheiro.Length - 1];

                    Guardado = true;

                    AtualizarTitulo();
                }
                catch
                {
                    MessageBox.Show("Erro na Leitura do ficheiro");
                }
                fs.Close();
            }
        }

        private void GuardarFicheiro()
        {
            if (DiretórioFicheiro == null)
            {
                GuardarComo();
                return;
            }
            FileStream fs = new FileStream(DiretórioFicheiro, FileMode.Create);

            try
            {
                formatter.Serialize(fs, Contactos.ToArray());

                Guardado = true;
                AtualizarTitulo();
            }
            catch
            {
                MessageBox.Show("Erro a guardar o ficheiro");
            }

            fs.Close();
        }

        private void GuardarComo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DiretórioFicheiro = saveFileDialog.FileName;

                    GuardarFicheiro();
                }
                catch
                {
                    MessageBox.Show("Erro a guardar o ficheiro");
                }
            }
        }

        private void Sair()
        {
            if (!ConfirmaNovoDocumento())
                return;

            Environment.Exit(0);
        }

        private bool ConfirmaNovoDocumento()
        {
            if (!Guardado)
            {
                DialogResult Resultado = MessageBox.Show(string.Format("Deseja guardar as alterações de {0}", NomeFicheiro), "agenda", MessageBoxButtons.YesNoCancel);

                if (Resultado == DialogResult.Cancel)
                    return false;

                if (Resultado == DialogResult.Yes)
                    GuardarFicheiro();
            }
            return true;
        }

       
        #endregion
    }
}
