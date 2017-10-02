using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_1
{
    public partial class Form1 : Form
    {

        string[] menu = { "Insira o nome a procurar", "Insira o número do ranking", "Insira o nome do jogador a alterar", "Insira o nome do jogador a eleminar" };
        string[] botao = { "Procurar", "Alterar", "Eleminar" };
        int opcao = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verifica();
        }

        private bool verifica(bool guardar = true)
        {                                       
            if ((int)numericUpDown1.Value + (int)numericUpDown2.Value < 10)
                if ((int)numericUpDown1.Value > (int)numericUpDown2.Value)
                    numericUpDown2.Value = 10 - numericUpDown1.Value;
                else
                    numericUpDown1.Value = 10 - numericUpDown2.Value;

            if ((int)numericUpDown1.Value + (int)numericUpDown2.Value > 10)
            {
                MessageBox.Show("O Jogador Não Pode Ter Feito Mais de 10 Jogos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textBox1.Text.Length > 0)
                if (comboBox1.SelectedIndex > -1)
                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if(guardar)
                            guarda();
                        return true;
                    }
                    else
                        MessageBox.Show("Selecione se o Jogador Ja Venceu Algum Torneio", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Selecione um Nacionalidade", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Preencha o Nome", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private void guarda()
        {
            bool JaVenceu;
            if (radioButton1.Checked)
                JaVenceu = true;
            else
                JaVenceu = false;

            ListaJogadores.listaJogadores.Add(new Rank { jogador = new Jogador() { Nome = textBox1.Text, Nacionalidade = comboBox1.SelectedItem.ToString() }, Vitorias = (int)numericUpDown1.Value, Derrotas = (int) numericUpDown2.Value, jaVenceu = JaVenceu});

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
            if (rank == null)
                return new ListViewItem();

            ListViewItem item = new ListViewItem(rank.jogador.Nome);
            item.SubItems.Add(rank.jogador.Nacionalidade);
            item.SubItems.Add(rank.Vitorias.ToString());
            item.SubItems.Add(rank.Derrotas.ToString());

            if(rank.jaVenceu)
                item.SubItems.Add("Sim");
            else
                item.SubItems.Add("Não");

            return item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string line in File.ReadAllLines("Nacionalidades.txt", Encoding.GetEncoding(28591)))
                comboBox1.Items.Add(line);
            updateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedItem = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rank jogador = null;

            switch (opcao)
            {
                case 0:
                    listView1.Items.Clear();
                    jogador = ListaJogadores.localizaJogador(textBox2.Text);
                    listView1.Items.Add(addItem(jogador));
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    listView1.Items.Clear();
                    jogador = ListaJogadores.localizaRank(int.Parse(textBox2.Text));
                    listView1.Items.Add(addItem(jogador));
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    if (verifica())
                    {
                        bool JaVenceu;
                        if (radioButton1.Checked)
                            JaVenceu = true;
                        else
                            JaVenceu = false;
                        ListaJogadores.AlterarJogador(textBox2.Text, new Rank { jogador = new Jogador() { Nome = textBox1.Text, Nacionalidade = comboBox1.SelectedItem.ToString() }, Vitorias = (int)numericUpDown1.Value, Derrotas = (int)numericUpDown2.Value, jaVenceu = JaVenceu });
                        updateListView();
                    }
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    ListaJogadores.RemoveJogador(textBox2.Text);
                    updateListView();
                    Console.WriteLine("Case 3");
                    break;
                default:
                    break;
            }

            textBox2.Visible = false;
            button2.Visible = false;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = menu[0];
            button2.Text = botao[0];
            textBox2.Visible = true;
            button2.Visible = true;
            opcao = 0;
        }

        private void porPosiçãoNoRankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = menu[1];
            button2.Text = botao[0];
            textBox2.Visible = true;
            button2.Visible = true;
            opcao = 1;
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = menu[2];
            button2.Text = botao[1];
            textBox2.Visible = true;
            button2.Visible = true;
            opcao = 2;
        }

        private void eleminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = menu[3];
            button2.Text = botao[2];
            textBox2.Visible = true;
            button2.Visible = true;
            opcao = 3;
        }
    }
}
