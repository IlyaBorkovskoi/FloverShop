using Cveti.Menu;
using Cveti.Menu.ForClients;
using System.Windows;

namespace Cveti
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Administrator_Click(object sender, RoutedEventArgs e)
        {
            Proverka admProverka = new Proverka();
            admProverka.Show();
        }

        private void Meneger_Click(object sender, RoutedEventArgs e)
        {
            Proverka manProverka = new Proverka();
            manProverka.Show();
        }

        private void Kassir_Click(object sender, RoutedEventArgs e)
        {
            Proverka kasProverka = new Proverka();
            kasProverka.Show();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Proverca clProverca = new Proverca();
            clProverca.Show();
        }
    }
}
