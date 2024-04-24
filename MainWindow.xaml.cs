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
            Proverka proverka = new Proverka();
            proverka.Show();
        }

        private void Meneger_Click(object sender, RoutedEventArgs e)
        {
            Proverka proverka = new Proverka();
            proverka.Show();
        }

        private void Kassir_Click(object sender, RoutedEventArgs e)
        {
            Proverka proverka = new Proverka();
            proverka.Show();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Proverca proverca = new Proverca();
            proverca.Show();
        }
    }
}
