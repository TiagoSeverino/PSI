using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ficha_2
{
    public partial class Notepad : Form
    {
        bool Guardado;
        string DiretórioFicheiro;
        string NomeFicheiro;
        List<string> Histórico;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;

        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                Filter = "Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = false
            };
            saveFileDialog = new SaveFileDialog
            {
                Filter = "Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true
            };

            Histórico = new List<string>();

            Guardado = true;
            NomeFicheiro = "Novo Documento";

            AtualizarTitulo();
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

        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextoMudado();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sair();
        }
        #endregion

        #region Funções

        private void AtualizarTitulo()
        {
            this.Text = (Guardado ? "" : "* ") + NomeFicheiro + " - Notepad";
        }

        private void NovoFicheiro()
        {
            if (!ConfirmaNovoDocumento())
                return;

            richTextBox1.Text = "";
            NomeFicheiro = "Novo Documento";
            DiretórioFicheiro = null;
            Guardado = true;

            AtualizarTitulo();
        }

        private void AbrirFicheiro()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);

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
            }
        }

        private void GuardarFicheiro()
        {
            if (DiretórioFicheiro == null)
            {
                GuardarComo();
                return;
            }

            try
            {
                File.WriteAllText(DiretórioFicheiro, richTextBox1.Text);
                Guardado = true;
                AtualizarTitulo();
            }
            catch
            {
                MessageBox.Show("Erro a guardar o ficheiro");
            }
        }

        private void GuardarComo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DiretórioFicheiro = saveFileDialog.FileName;
                    File.WriteAllText(DiretórioFicheiro, richTextBox1.Text);
                    Guardado = true;
                    AtualizarTitulo();
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

        private void TextoMudado()
        {
            Histórico.Add(richTextBox1.Text);
            Guardado = false;

            AtualizarTitulo();
        }

        private bool ConfirmaNovoDocumento()
        {
            if (!Guardado)
            {
                DialogResult Resultado = MessageBox.Show(string.Format("Deseja guardar as alterações de {0}", NomeFicheiro), "Notepad", MessageBoxButtons.YesNoCancel);

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
