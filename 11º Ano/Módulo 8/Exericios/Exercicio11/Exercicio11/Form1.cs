using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio11
{
    public partial class Form1 : Form
    {
        int cor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            if (tB1.Text == "" || tB1.Text == null || tB2.Text == "" || tB2.Text == null)
            {
                MessageBox.Show("Insira Os Números Para Realizar O Cálculo");
                return;
            }

            int o = cB1.SelectedIndex;

            switch (o)
            {
                case 0:
                    tB3.Text = "" + (double.Parse(tB1.Text) + double.Parse(tB2.Text));
                    break;
                case 1:
                    tB3.Text = "" + (double.Parse(tB1.Text) - double.Parse(tB2.Text));
                    break;
                case 2:
                    tB3.Text = "" + (double.Parse(tB1.Text) * double.Parse(tB2.Text));
                    break;
                case 3:
                    tB3.Text = "" + (double.Parse(tB1.Text) / double.Parse(tB2.Text));
                    break;
                default:
                    MessageBox.Show("Selecione A Operação!");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cB1.SelectedIndex = 0;
            cB1.DropDownStyle = ComboBoxStyle.DropDownList;
            mudaCor(0);
        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {
            try{
                double.Parse(tB1.Text);
            }
            catch
            {
                if (tB1.Text.Length > 0)
                {
                    tB1.Text = tB1.Text.Substring(0, tB1.Text.Length - 1);
                    tB1.SelectionStart = tB1.Text.Length;
                }
                else
                {
                    tB1.Text = null;
                }
               
            }
        }

        private void tB2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tB2.Text);
            }
            catch
            {
                if (tB2.Text.Length > 0)
                {
                    tB2.Text = tB2.Text.Substring(0, tB2.Text.Length - 1);
                    tB2.SelectionStart = tB2.Text.Length;
                }
                else
                {
                    tB2.Text = null;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mudarCor(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mudarCor(0);
        }

        private void mudarCor(int c = 0)
        {
            //0 = Ultima, 1 = Proxima
            if (c == 0)
            {
                if (cor > 0)
                {
                    mudaCor(cor-1);
                }
                else
                {
                    mudaCor(3);
                }
            }
            else
            {
                if (cor < 2)
                {
                    mudaCor(cor + 1);
                }
                else
                {
                    mudaCor(0);
                }
            }
        }

        private void mudaCor(int c)
        {
            switch (c)
            {
                case 0:
                    BackColor = Color.Blue;
                    break;
                case 1:
                    BackColor = Color.Red;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                default:
                    break;
            }

            cor = c;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tB1.Text = "";
            tB2.Text = "";
            tB3.Text = "";
        }
    }
}
