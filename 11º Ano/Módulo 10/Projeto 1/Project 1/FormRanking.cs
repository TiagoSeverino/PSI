using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class FormRanking : Form
    {
        public FormRanking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRanking_Load(object sender, EventArgs e)
        {
            ListaJogadores.ordenaVitorias();
            updateListView();
        }

        private void updateListView()
        {
            listView1.Items.Clear();

            foreach (Rank rank in ListaJogadores.listaJogadores)
                listView1.Items.Add(addItem(rank));
        }

        private ListViewItem addItem(Rank rank)
        {
            ListViewItem item = new ListViewItem(rank.posição.ToString());
            item.SubItems.Add(rank.jogador.Nome);

            return item;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
