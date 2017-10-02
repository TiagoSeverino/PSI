using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbH.Text);
            }
            catch
            {
                if (tbH.Text.Length > 0)
                {
                    tbH.Text = tbH.Text.Substring(0, tbH.Text.Length - 1);
                    tbH.SelectionStart = tbH.Text.Length;
                }
                else
                {
                    tbH.Text = null;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbIdeal.Visible = false;
            lbResultado.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool f = rbtnFeminino.Checked, m = rbtnMasculino.Checked;
            
            if (f == true || m == true)
            {
                if (tbKg.Text.Length > 0)
                {
                    if (tbH.Text.Length > 0)
                    {
                        double kg = Double.Parse(tbKg.Text), h = Double.Parse(tbH.Text);

                        double imc = kg / (h * h);

                        double pesoIdeal;

                        if (f)
                        {
                            pesoIdeal = 61.1 * h - 44.7;
                        }
                        else
                        {
                            pesoIdeal = 72.7 * h - 58;
                        }

                        lbIdeal.Visible = true;
                        lbResultado.Visible = true;

                        lbIdeal.Text = pesoIdeal.ToString();

                        if (f)
                        {
                            if (imc >= 32.3)
                            {
                                lbResultado.Text = "Obesidade";
                                pictureBox1.Image = Properties.Resources.superfat;
                            }
                            else
                            {
                                if (imc >= 27.4)
                                {
                                    lbResultado.Text = "Acima Do peso";
                                    pictureBox1.Image = Properties.Resources.fat;
                                }
                                else
                                {
                                    if (imc >= 25.9)
                                    {
                                        lbResultado.Text = "Um Pouco Acima Do Peso";
                                        pictureBox1.Image = Properties.Resources.overweight;
                                    }
                                    else
                                    {
                                        if (imc >= 19.2)
                                        {
                                            lbResultado.Text = "Peso Ideal";
                                            pictureBox1.Image = Properties.Resources.healthy;
                                        }
                                        else
                                        {
                                            lbResultado.Text = "Abaixo Do Peso";
                                            pictureBox1.Image = Properties.Resources.slim;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (imc >= 31.2)
                            {
                                lbResultado.Text = "Obesidade";
                                pictureBox1.Image = Properties.Resources.superfat;
                            }
                            else
                            {
                                if (imc >= 27.9)
                                {
                                    lbResultado.Text = "Acima Do peso";
                                    pictureBox1.Image = Properties.Resources.fat;
                                }
                                else
                                {
                                    if (imc >= 26.5)
                                    {
                                        lbResultado.Text = "Um Pouco Acima Do Peso";
                                        pictureBox1.Image = Properties.Resources.overweight;
                                    }
                                    else
                                    {
                                        if (imc >= 20.7)
                                        {
                                            lbResultado.Text = "Peso Ideal";
                                            pictureBox1.Image = Properties.Resources.healthy;
                                        }
                                        else
                                        {
                                            lbResultado.Text = "Abaixo Do Peso";
                                            pictureBox1.Image = Properties.Resources.slim;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira A Altura");
                    }
                }else
                {
                    MessageBox.Show("Insira O Peso");
                }
            }else
            {
                MessageBox.Show("Selecione O Sexo");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbIdeal.Visible = false;
            lbResultado.Visible = false;

            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;

            tbH.Text = "";
            tbKg.Text = "";

            pictureBox1.Image = null;

            tbH.Focus();
        }

        private void tbKg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbKg.Text);
            }
            catch
            {
                if (tbKg.Text.Length > 0)
                {
                    tbKg.Text = tbKg.Text.Substring(0, tbKg.Text.Length - 1);
                    tbKg.SelectionStart = tbKg.Text.Length;
                }
                else
                {
                    tbKg.Text = null;
                }
            }
        }
    }
}
