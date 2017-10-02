using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Projeto_2
{
    public partial class FormGestãoProfessores : Form
    {
        string[] ButtonOpçãoText = { "Guardar", "Alterar", "Eleminar" };

        public FormGestãoProfessores()
        {
            InitializeComponent();
        }

        private void FormGestãoProfessores_Load(object sender, EventArgs e)
        {
            SetButtonOpção(0);
        }

        private void Sair()
        {
            this.Close();
        }

        private void SetButtonOpção(int Button)
        {
            BtnOpção.Text = ButtonOpçãoText[Button];
        }

        private int GetButtonOpção()
        {
            switch (BtnOpção.Text)
            {
                case "Alterar":
                    return 1;

                case "Eleminar":
                    return 2;

                case "Guardar":
                default:
                    return 0;
            }
        }

        private void GereButtonOpção()
        {
            switch (GetButtonOpção())
            {
                case 0:
                    Gravar();
                    break;

                case 1:
                    Alterar();
                    break;

                case 3:
                default:
                    Eleminar();
                    break;
            }
            Limpar();
        }

        private void Limpar()
        {
            textBoxContacto.Text = "";
            textBoxGrupoDisciplinar.Text = "";
            textBoxNome.Text = "";
        }

        private void Gravar()
        {
            if (ValidaEntradas())
                Professores.AdicionaProfessor(textBoxNome.Text, textBoxContacto.Text, textBoxGrupoDisciplinar.Text);
        }

        private void Alterar()
        {
            if (ValidaEntradas())
            {
                int nrProfessor = 0;

                if (InputCodigoProfessor(ref nrProfessor, "Alterar Professor"))
                    if (!Professores.AlteraProfessor(textBoxNome.Text, textBoxContacto.Text, textBoxGrupoDisciplinar.Text, nrProfessor))
                        MessageBox.Show(null, "Erro ao alterar Professor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eleminar()
        {
            int nrProfessor = 0;

            if (InputCodigoProfessor(ref nrProfessor, "Eleminar Professor"))
                if (!Professores.EleminaProfessor(nrProfessor)) 
                    MessageBox.Show(null, "Erro Ao Eleminar Professor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidaEntradas()
        {
            if (textBoxNome.Text == String.Empty || textBoxContacto.Text == String.Empty || textBoxGrupoDisciplinar.Text == String.Empty)
            {
                MessageBox.Show(null, "Complete Todos Os Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool InputCodigoProfessor(ref int nrProfessor, string Titulo)
        {
            try
            {
                nrProfessor = int.Parse(Interaction.InputBox("Insira O Número Do Professor", "Eleminar Professor"));
                return true;
            }
            catch
            {
                MessageBox.Show(null, "Número Inválido", Titulo, MessageBoxButtons.OK);
                return false;
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu.AbrirMenuSobre();
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetButtonOpção(0);
        }

        private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetButtonOpção(1);
        }

        private void EleminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetButtonOpção(2);
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void BtnOpção_Click(object sender, EventArgs e)
        {
            GereButtonOpção();
        }
    }
}