using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projeto_Final
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        bool VerificaGeral()
        {
            return !(nomeMutuário.Text == String.Empty || nomeBiblioteca.Text == String.Empty || nomeEditor.Text == String.Empty || !(rbDisponivel.IsChecked.Value || rbIndisponivel.IsChecked.Value));
        }

        bool VerificaLivro()
        {
            return !(titulo.Text == String.Empty);
        }

        bool VerificaVideo()
        {
            return !(titulo.Text == String.Empty || nomeRealizador.Text == String.Empty || !int.TryParse(anoPublicação.Text, out int a));
        }

        void AddJornal()
        {
            Obras.AddJornal(rbDisponivel.IsChecked.Value, nomeMutuário.Text, dpDataPublicação.Text, nomeBiblioteca.Text, nomeEditor.Text);
        }

        void AddLivro()
        {
            Obras.AddLivro(rbDisponivel.IsChecked.Value, nomeMutuário.Text, dpDataPublicação.Text, nomeBiblioteca.Text, nomeEditor.Text, titulo.Text, dpDataPublicação.Text);
        }

        void AddRevista()
        {
            Obras.AddRevista(rbDisponivel.IsChecked.Value, nomeMutuário.Text, dpDataPublicação.Text, nomeBiblioteca.Text, nomeEditor.Text);
        }

        void AddVideo()
        {
            Obras.AddVideo(rbDisponivel.IsChecked.Value, nomeMutuário.Text, dpDataPublicação.Text, nomeBiblioteca.Text, nomeEditor.Text, titulo.Text, nomeRealizador.Text, int.Parse(anoPublicação.Text));
        }

        void Aviso()
        {
            MessageBox.Show("davssvdv");
        }

        void Limpar()
        {
            rbIndisponivel.IsChecked = false;
            rbDisponivel.IsChecked = false;
            nomeMutuário.Text = "";
            dpDataPublicação.Text = "";
            dpDataReaçização.Text = "";
            nomeBiblioteca.Text = "";
            nomeEditor.Text = "";
            titulo.Text = "";
            dpDataPublicação.Text = "";
            nomeRealizador.Text = "";
            anoPublicação.Text = "";
        }

        void UpdateListBox()
        {
            listView.ItemsSource = Obras.obras;

            /*
            foreach (Obra obra in Obras.obras)
            {
                listView.Items.Add(obra.NomeBiblioteca);
            }
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (VerificaGeral())
            {
                if (rbJornalPeriodico.IsChecked.Value)
                {
                    AddJornal();
                    Limpar();
                    return;
                }

                if (rbLivro.IsChecked.Value)
                    if (VerificaLivro())
                    {
                        AddLivro();
                        Limpar();
                        return;
                    }
                    else
                        Aviso();

                if (rbRevista.IsChecked.Value)
                {
                    AddRevista();
                    Limpar();
                    return;
                }

                if (rbVideo.IsChecked.Value)
                    if (VerificaVideo())
                    {
                        AddVideo();
                        Limpar();
                        return;
                    }
                    else
                    {
                        Aviso();
                    }
            }
            else
            {
                Aviso();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateListBox();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
