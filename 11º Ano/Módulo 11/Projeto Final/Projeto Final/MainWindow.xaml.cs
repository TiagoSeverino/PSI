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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Utilizadores.Valida(user.Text, pass.Password))
            {
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();

                mainMenu.Closed += new EventHandler (delegate
                 {
                     Environment.Exit(0);
                 });
            }
        }
    }
}
