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
    public partial class Main : Form
    {
        Stock stock;

        public Main()
        {
            InitializeComponent();
            stock = new Stock();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void novoCarro()
        {
            MenuCarro mc = new MenuCarro();

            mc.setMarcas(stock.getMarcas());

            mc.Show();

            mc.FormClosed += new FormClosedEventHandler(delegate
            {
                if (mc.guardado)
                {
                stock.novoCarro(new Automovel(stock.procuraMarca(mc.cbMarcas.SelectedItem.ToString()), mc.tbModelo.Text, double.Parse(mc.tbPreco.Text), mc.tbCor.Text, double.Parse(mc.tbZeroCem.Text), double.Parse(mc.tbConsumo.Text), mc.tbExtras.Text, int.Parse(mc.tbStock.Text), int.Parse(mc.tbVendas.Text)));
                    updateListView();
                }
            });
        }

        private void novaMarca()
        {
            MenuMarca mc = new MenuMarca();

            mc.Show();

            mc.FormClosed += new FormClosedEventHandler(delegate
            {
                if (mc.guardado)
                {
                    stock.novaMarca(mc.tbMarca.Text, mc.tbPais.Text);
                    updateListView();
                }
            });
        }

        private void updateListView()
        {
            listView1.Items.Clear();

            foreach (Automovel carro in stock.Automoveis)
                listView1.Items.Add(listCarro(carro.modelo, carro.marca.nome, carro.preco.ToString(), carro.cor, carro.zeroCem.ToString(), carro.consumo.ToString(), carro.extras, carro.stock.ToString(), carro.vendas.ToString()));

        }

        private void tbProcuraCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbProcuraCarro.Text.Length > 0 && stock.procuraCarros(tbProcuraCarro.Text) != null)
            {
                listView1.Items.Clear();

                List<Automovel> proCarro = stock.procuraCarros(tbProcuraCarro.Text);

                foreach(Automovel carro in proCarro)
                    listView1.Items.Add(listCarro(carro.modelo, carro.marca.nome, carro.preco.ToString(), carro.cor, carro.zeroCem.ToString(), carro.consumo.ToString(), carro.extras, carro.stock.ToString(), carro.vendas.ToString()));
            }
            else
            {
                updateListView();
            }
        }

        private ListViewItem listCarro(string modelo, string marca, string preco, string cor, string zeroCem, string consumo, string extras, string stock, string vendas)
        {
            ListViewItem item = new ListViewItem(modelo);
            item.SubItems.Add(marca);
            item.SubItems.Add(preco);
            item.SubItems.Add(cor);
            item.SubItems.Add(zeroCem);
            item.SubItems.Add(consumo);
            item.SubItems.Add(extras);
            item.SubItems.Add(stock);
            item.SubItems.Add(vendas);

            return item;
        }

        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            novoCarro();
        }

        private void btnNovaMarca_Click(object sender, EventArgs e)
        {
            novaMarca();
        }

        private void btnEleminarCarro_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if(listView1.SelectedItems.Count == 1)
                {
                    stock.eleminaCarro(listView1.SelectedItems[0].Text);
                }
                else
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                        stock.eleminaCarro(item.Text);
                }
            }
            
            updateListView();
        }

        private void btnAdicionaStock_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                stock.updateStock(item.Text, (int)numUDStock.Value);
            updateListView();
        }

        private void btnAdicionaVendas_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                if(!stock.updateVendas(item.Text, (int)numUDVendas.Value))
                    MessageBox.Show("Não Possui Veiculos Em Stock Suficientes", "Aviso!");
            updateListView();
        }
    }
}
