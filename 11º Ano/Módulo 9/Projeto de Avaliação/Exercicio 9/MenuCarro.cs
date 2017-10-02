using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_9
{
    public partial class MenuCarro : Form
    {
        public bool guardado = false;
        string[] marcas;
        
        public MenuCarro()
        {
            InitializeComponent();
        }

        public void setMarcas(string[] Marcas)
        {
            marcas = Marcas;

            for (int i = 0; i < marcas.Length; i++)
            {
                cbMarcas.Items.Add(marcas[i]);
            }
        }

        private void MenuCarro_Load(object sender, EventArgs e)
        {
            FormClosing += new FormClosingEventHandler(MenuCarro_FormClosing);
        }

        private void MenuCarro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                DialogResult msg = MessageBox.Show("Deseja guardar as alterações efectuadas?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                    e.Cancel = true;
            }
            else
            {
                if (cbMarcas.SelectedIndex < 0 || tbModelo.Text.Length == 0 || tbPreco.Text.Length == 0 || tbCor.Text.Length == 0 || tbZeroCem.Text.Length == 0 || tbConsumo.Text.Length == 0 || tbExtras.Text.Length == 0 || tbStock.Text.Length == 0 || tbVendas.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardado = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardado = false;
            this.Close();
        }

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbPreco.Text);
            }
            catch
            {
                if (tbPreco.Text.Length > 0)
                {
                    tbPreco.Text = tbPreco.Text.Substring(0, tbPreco.Text.Length - 1);
                    tbPreco.SelectionStart = tbPreco.Text.Length;
                }
                else
                {
                    tbPreco.Text = "";
                }
            }
        }

        private void tbZeroCem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbZeroCem.Text);
            }
            catch
            {
                if (tbZeroCem.Text.Length > 0)
                {
                    tbZeroCem.Text = tbZeroCem.Text.Substring(0, tbZeroCem.Text.Length - 1);
                    tbZeroCem.SelectionStart = tbZeroCem.Text.Length;
                }
                else
                {
                    tbZeroCem.Text = "";
                }
            }
        }

        private void tbConsumo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbConsumo.Text);
            }
            catch
            {
                if (tbConsumo.Text.Length > 0)
                {
                    tbConsumo.Text = tbConsumo.Text.Substring(0, tbConsumo.Text.Length - 1);
                    tbConsumo.SelectionStart = tbConsumo.Text.Length;
                }
                else
                {
                    tbConsumo.Text = "";
                }
            }
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbStock.Text);
            }
            catch
            {
                if (tbStock.Text.Length > 0)
                {
                    tbStock.Text = tbStock.Text.Substring(0, tbStock.Text.Length - 1);
                    tbStock.SelectionStart = tbStock.Text.Length;
                }
                else
                {
                    tbStock.Text = "";
                }
            }
        }

        private void tbVendas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbVendas.Text);
            }
            catch
            {
                if (tbVendas.Text.Length > 0)
                {
                    tbVendas.Text = tbVendas.Text.Substring(0, tbVendas.Text.Length - 1);
                    tbVendas.SelectionStart = tbVendas.Text.Length;
                }
                else
                {
                    tbVendas.Text = "";
                }
            }
        }
    }
}
