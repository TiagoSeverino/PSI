using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FichaAvaliação_1.Pizzas;

namespace FichaAvaliação_1
{
    public partial class FormRegistoVendas : Form
    {
        public FormRegistoVendas()
        {
            InitializeComponent();
        }

        private void FormRegistoVendas_Load(object sender, EventArgs e)
        {
            foreach (Pizza pizza in ListaPizzas)
            {
                comboBox1.Items.Add(pizza.Nome);
            }
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            ListaVendaPizzas.Add(new VendaPizzas(dateTimePicker1.Value, comboBox1.SelectedItem.ToString(), (int) numericUpDown1.Value));
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            listView1.Items.Clear();

            foreach(VendaPizzas pizza in ListaVendaPizzas)
            {
                listView1.Items.Add(new ListViewItem(new string[] { pizza.Data.ToLongDateString(), pizza.NomePizza, pizza.Quantidade.ToString() }));
            }
        }
    }
}
