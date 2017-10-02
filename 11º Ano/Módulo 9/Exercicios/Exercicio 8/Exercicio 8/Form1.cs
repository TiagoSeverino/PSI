using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_8
{
    public partial class Form1 : Form
    {
        private Bitmap img = null;
        Agenda agenda = new Agenda(1000);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "Imagem|*.png|Imagem|*.jpg|Imagem|*.jpeg";
            openFileDialog1.ShowDialog();
            string imagem = openFileDialog1.FileName;

            img = (Bitmap) Image.FromFile(imagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = agenda.adicionaContacto(nome.Text, telemovel.Text, email.Text, dataNasc.Text, img);

            listView1.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                ListViewItem contacto = new ListViewItem(agenda.contactos[i].nome);
                contacto.SubItems.Add(agenda.contactos[i].telemovel);
                contacto.SubItems.Add(agenda.contactos[i].email);
                contacto.SubItems.Add(agenda.contactos[i].dataNascimento);

                //contacto.SubItems.Add(agenda.contactos[i].foto);

                listView1.Items.Add(contacto);
            }
        }
    }
}
