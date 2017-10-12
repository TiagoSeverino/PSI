using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static FichaAvaliação_1.Pizzas;

namespace FichaAvaliação_1
{
    public partial class FormInserirPizza : Form
    {
        BinaryFormatter formatter;
    
        public FormInserirPizza()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formatter = new BinaryFormatter();

            pictureBox.Image = Properties.Resources.No_Pizza_Image;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Bella Vita Pizza (*.bvp)|*.bvp|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);

                try
                {
                    ListaPizzas.Add(new Pizza(tBNome.Text, tBIng1.Text, tBIng2.Text, tBIng3.Text, tBIng4.Text, tBIng5.Text, pictureBox.Image));
                    formatter.Serialize(fs, ListaPizzas);
                    Limpar();

                    //ListaPizzas = (List<Pizza>) formatter.Deserialize(fs);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro na gravação do ficheiro" + ex.Message);
                }

                fs.Close();
            }
        }

        private void Limpar()
        {
            tBNome.Text = "";
            tBIng1.Text = "";
            tBIng2.Text = "";
            tBIng3.Text = "";
            tBIng4.Text = "";
            tBIng5.Text = "";
            pictureBox.Image = Properties.Resources.No_Pizza_Image;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Erro na abertura da imagem");
                }
            }
        }
    }
}
