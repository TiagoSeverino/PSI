using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Mod8
{
    public partial class Form1 : Form
    {
        string lText = string.Empty;
        int[] historico = new int[100000];
        int i = 0;
        const int MIN = 0, MAX = 20;
        int random;

        public Form1()
        {
            InitializeComponent();
            novoRand();
        }

        private void novoRand()
        {
            Random rnd = new Random();

            random = rnd.Next(MIN, MAX);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                int palpite = int.Parse(tbPalpite.Text);

                if (palpite<MIN || palpite > MAX)
                {
                    throw new ArgumentNullException();
                }

                historico[i]++;

                if (palpite == random)
                {
                    string outp = "";

                    for (int c = 0; c <= i; c++)
                        outp += (c+1) + "º jogo : " + historico[c] + " | ";

                    MessageBox.Show("Acertou!\nTentativas: " + outp);
                    novoRand();
                    i++;
                }
                else
                {
                    if (palpite < random)
                    {
                        MessageBox.Show("O seu palpite foi abaixo do resultado certo!");
                    }
                    else
                    {
                        MessageBox.Show("O seu palpite foi acima do resultado certo!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Insira Um Número entre " + MIN + " e " + MAX + "!");
            }

            tbPalpite.Text = string.Empty;

            tbPalpite.Focus();
        }

        private void tbPalpite_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lText = int.Parse(tbPalpite.Text).ToString();
            }
            catch
            {
                if (tbPalpite.Text.Length == 0)
                    lText = tbPalpite.Text;
                tbPalpite.Text = lText;
            }
        }
    }
}
