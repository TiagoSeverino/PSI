using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaAvaliação_1
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInserirPizza formInserirPizza = new FormInserirPizza();
            formInserirPizza.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistoVendas formRegistoVendas = new FormRegistoVendas();
            formRegistoVendas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTop5 formTop5 = new FormTop5();
            formTop5.ShowDialog();
        }
    }
}
