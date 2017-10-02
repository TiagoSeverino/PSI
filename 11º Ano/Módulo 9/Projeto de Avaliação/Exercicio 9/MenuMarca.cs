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
    public partial class MenuMarca : Form
    {
        public bool guardado = false;

        public MenuMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardado = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guardado = false;
            this.Close();
        }

        private void MenuMarca_Load(object sender, EventArgs e)
        {
            FormClosing += new FormClosingEventHandler(MenuMarca_FormClosing);
        }

        private void MenuMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                DialogResult msg = MessageBox.Show("Deseja guardar as alterações efectuadas?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                    e.Cancel = true;
            }
            else
            {
                if (tbMarca.Text.Length == 0 || tbPais.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
                    
            }
        }
    }
}
