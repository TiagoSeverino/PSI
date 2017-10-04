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
        bool FoiRetrocedido;
        string NomeFicheiro;
        FontDialog fontDialog;
        List<string> Histórico;
        string DiretórioFicheiro;
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
            fontDialog = new FontDialog();

            Histórico = new List<string>();

            FoiRetrocedido = false;
            Guardado = true;
            NomeFicheiro = "Novo Documento";

            AtualizarTitulo();
            Histórico.Add(richTextBox.Text);
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
            Retroceder();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MudarFonte();
        }

        private void sobreNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostarSobre();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
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

            richTextBox.Text = "";
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
                    richTextBox.Text = File.ReadAllText(openFileDialog.FileName);

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
                File.WriteAllText(DiretórioFicheiro, richTextBox.Text);
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
                    File.WriteAllText(DiretórioFicheiro, richTextBox.Text);
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

        private void Retroceder()
        {
            if (Histórico.Count > 1)
            {
                Histórico.RemoveAt(Histórico.Count - 1);
                FoiRetrocedido = true;
                richTextBox.Text = Histórico[Histórico.Count - 1];
            }
        }

        private void Cortar()
        {
            richTextBox.Cut();
        }

        private void Copiar()
        {
            richTextBox.Copy();
        }

        private void Colar()
        {
            richTextBox.Paste();
        }

        private void MudarFonte()
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog.Font;
            }
        }

        private void MostarSobre()
        {
            FormSobre sobre = new FormSobre();
            sobre.ShowDialog();
            
        }

        private void TextoMudado()
        {
            if (!FoiRetrocedido)
                Histórico.Add(richTextBox.Text);

            FoiRetrocedido = false;
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
