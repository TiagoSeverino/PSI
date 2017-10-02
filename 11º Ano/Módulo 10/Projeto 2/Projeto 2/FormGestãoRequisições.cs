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
    public partial class FormgestãoRequisições : Form
    {
        string[] ButtonOpçãoText = { "Guardar", "Alterar", "Eleminar" };

        public FormgestãoRequisições()
        {
            InitializeComponent();
        }

        private void FormgestãoRequisições_Load(object sender, EventArgs e)
        {
            SetBotão(0);
            SetUpComboBoxNumeroProfessor();
            SetUpComboBoxCodigoProjetor();
        }

        private void SetUpComboBoxNumeroProfessor()
        {
            foreach(Professor professor in Professores.GetListProfessores())
                comboBoxNúmeroProfessor.Items.Add(professor.NrProfessor);
        }

        private void SetUpComboBoxCodigoProjetor()
        {
            Requisições.OrdenaDataEntrega();

            foreach(Projetor projetor in Projetores.GetListProjetores())
            {
                if (!projetor.IsFuncional)
                    break;

                bool adiciona = true;

                foreach(Requisição requisição in Requisições.GetListRequisição())
                {
                    if(projetor.Codigo == requisição.CodigoProjetor)
                    {
                        adiciona = requisição.IsEntregue;
                        break;
                    }
                }

                if (adiciona)
                {
                    comboBoxCódigoProjetor.Items.Add(projetor.Codigo);
                }
            }
        }

        private void SetBotão(int NrBotão)
        {
            ButtonOpção.Text = ButtonOpçãoText[NrBotão];
        }

        private int GetBotão()
        {
            switch (ButtonOpção.Text)
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

        private void GerirBotão()
        {
            switch (GetBotão())
            {
                case 0:
                    Guardar();
                    break;
                case 1:
                    Alterar();
                    break;
                case 2:
                default:
                    Eleminar();
                    break;
            }
            Limpar();
        }

        private void Guardar()
        {
            if (Validar())
                if (isCompleto())
                    Requisições.AdicionaRegisto(int.Parse(comboBoxNúmeroProfessor.SelectedItem.ToString()), comboBoxCódigoProjetor.SelectedItem.ToString(), dateTimePickerDataRequisição.Value, (int)numericUpDownDuraçãoRequisição.Value, radioButtonEntregue.Checked, dateTimePickerDataEntrega.Value);
                else
                    Requisições.AdicionaRegisto(int.Parse(comboBoxNúmeroProfessor.SelectedItem.ToString()), comboBoxCódigoProjetor.SelectedItem.ToString(), dateTimePickerDataRequisição.Value, (int) numericUpDownDuraçãoRequisição.Value);
        }

        private void Alterar()
        {
            int NrRequisição = 0;

            if (Validar())
                if (InputCodigoProjetor(ref NrRequisição))
                    if (isCompleto())
                        Requisições.AlteraRegisto(NrRequisição, int.Parse(comboBoxNúmeroProfessor.SelectedItem.ToString()), comboBoxCódigoProjetor.SelectedItem.ToString(), dateTimePickerDataRequisição.Value, (int)numericUpDownDuraçãoRequisição.Value, radioButtonEntregue.Checked, dateTimePickerDataEntrega.Value);
                    else
                        Requisições.AlteraRegisto(NrRequisição, int.Parse(comboBoxNúmeroProfessor.SelectedItem.ToString()), comboBoxCódigoProjetor.SelectedItem.ToString(), dateTimePickerDataRequisição.Value, (int) numericUpDownDuraçãoRequisição.Value);
                else
                    MessageBox.Show(null, "Número de Requisição Inválido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Eleminar()
        {
            int NrRequisição = 0;

            if (InputCodigoProjetor(ref NrRequisição))
                Requisições.EleminaRegistos(NrRequisição);
            else
                MessageBox.Show(null, "Número de Requisição Inválido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        }

        private bool Validar()
        {
            if (comboBoxNúmeroProfessor.SelectedIndex == -1 || comboBoxCódigoProjetor.SelectedIndex == -1 || numericUpDownDuraçãoRequisição.Value == 0)
            {
                MessageBox.Show(null, "Preencha Todos os campos corretamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool isCompleto()
        {
            if (!radioButtonEntregue.Checked && !radioButtonEntregueNão.Checked)
                return false;

            return true;
        }

        private void Limpar()
        {
            comboBoxCódigoProjetor.SelectedIndex = -1;
            comboBoxNúmeroProfessor.SelectedIndex = -1;
            numericUpDownDuraçãoRequisição.Value = 0;
            radioButtonEntregue.Checked = false;
            radioButtonEntregueNão.Checked = false;
        }

        private bool InputCodigoProjetor(ref int NúmeroRequisição)
        {
            try
            {
                NúmeroRequisição = int.Parse(Interaction.InputBox("Insira O número da requisição", "Alterar Requisição"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu.AbrirMenuSobre();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            this.Close();
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

        private void ButtonOpção_Click(object sender, EventArgs e)
        {
            GerirBotão();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
