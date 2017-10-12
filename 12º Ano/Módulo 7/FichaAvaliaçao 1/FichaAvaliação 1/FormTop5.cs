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
    public partial class FormTop5 : Form
    {
        public FormTop5()
        {
            InitializeComponent();
        }

        private void FormTop5_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<VendaPizzas> rank = ListaVendaPizzas.OrderByDescending(item => item.Quantidade).ToList();

            for (int i = 0; i < rank.Count && i < 5; i++)
            {
                VendaPizzas pizza = rank[i];
                listView1.Items.Add(new ListViewItem(new string[] { pizza.Quantidade.ToString(), pizza.NomePizza }));
            }
        }
    }
}
