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
    public partial class FormGestãoProjetores : Form
    {
        string[] ButtonOpçãoText = { "Guardar", "Alterar", "Eleminar" };

        public FormGestãoProjetores()
        {
            InitializeComponent();
        }

        private void FormGestãoProjetores_Load(object sender, EventArgs e)
        {
            SetBotão(0);
        }

        private int GetBotão()
        {
            switch (ButtonOpção.Text)
            {
                case "Alterar":
                    return 1;
                case "Eleminar":
                    return 2;
                default:
                    return 0;
            }
        }

        private void SetBotão(int Button)
        {
            ButtonOpção.Text = ButtonOpçãoText[Button];
        }

        private void GereButtonOpção()
        {
            switch (GetBotão())
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
            textBoxCodigo.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            radioButtonFunciona.Checked = false;
            radioButtonFuncionaNao.Checked = false;
        }

        private void Gravar()
        {
            if (ValidaEntradas())
            {
                Projetores.AdicionaProjetor(textBoxCodigo.Text, textBoxMarca.Text, textBoxModelo.Text, radioButtonFunciona.Checked);
            }
        }

        private void Alterar()
        {
            if (ValidaEntradas())
            {
                if (!Projetores.AlteraProjetor(InputCodigoProjetor(), textBoxCodigo.Text, textBoxMarca.Text, textBoxModelo.Text, radioButtonFunciona.Checked))
                    MessageBox.Show(null, "Erro Ao Alterar Projetor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eleminar()
        {
                if (!Projetores.EleminaProjetores(InputCodigoProjetor()))
                    MessageBox.Show(null, "Erro Ao Eleminar Projetor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string InputCodigoProjetor()
        {
                return Interaction.InputBox("Insira O Código do Projetor", "Eleminar Projetor");
        }

        private bool ValidaEntradas()
        {
            if(textBoxCodigo.Text == string.Empty || textBoxMarca.Text == string.Empty || textBoxModelo.Text == string.Empty || !(radioButtonFunciona.Checked || radioButtonFuncionaNao.Checked))
            {
                MessageBox.Show(null, "Preencha Todos os campos corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Sair()
        {
            this.Close();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBotão(0);
        }

        private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBotão(1);
        }

        private void EleminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBotão(2);
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu.AbrirMenuSobre();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void ButtonOpção_Click(object sender, EventArgs e)
        {
            GereButtonOpção();
        }
    }
}
