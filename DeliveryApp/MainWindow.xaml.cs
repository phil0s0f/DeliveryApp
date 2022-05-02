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

namespace DeliveryApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WIN-QKR690LSI08
        }

        private void OpenViewPostavshik(object sender, RoutedEventArgs e)
        {
            ViewPostavshik form = new ViewPostavshik();
            form.Show();
        }

        private void OpenViewDogovor(object sender, RoutedEventArgs e)
        {
            ViewDogovor form = new ViewDogovor();
            form.Show();
        }

        private void OpenViewFizLico(object sender, RoutedEventArgs e)
        {
            ViewFizLico form = new ViewFizLico();
            form.Show();
        }

        private void OpenViewUrLico(object sender, RoutedEventArgs e)
        {
            ViewUrLico form = new ViewUrLico();
            form.Show();
        }

        private void OpenViewPostavleno(object sender, RoutedEventArgs e)
        {
            ViewPostavleno form = new ViewPostavleno();
            form.Show();
        }
    }
}
