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

        private void OpenAddPostavshik(object sender, RoutedEventArgs e)
        {
            AddPostavshik form = new AddPostavshik();
            form.Show();
        }

        private void OpenAddDogovor(object sender, RoutedEventArgs e)
        {
            AddDogovor form = new AddDogovor();
            form.Show();
        }

        private void OpenAddFizLico(object sender, RoutedEventArgs e)
        {
            AddFizLico form = new AddFizLico();
            form.Show();
        }

        private void OpenAddUrLico(object sender, RoutedEventArgs e)
        {
            AddUrLico form = new AddUrLico();
            form.Show();
        }

        private void OpenAddPostavleno(object sender, RoutedEventArgs e)
        {
            AddPostavleno form = new AddPostavleno();
            form.Show();
        }

        private void OpenEditPostavshik(object sender, RoutedEventArgs e)
        {
            EditPostavshik form = new EditPostavshik();
            form.Show();
        }

        private void OpenEditDogovor(object sender, RoutedEventArgs e)
        {
            EditDogovor form = new EditDogovor();
            form.Show();
        }

        private void OpenEditFizLico(object sender, RoutedEventArgs e)
        {
            EditFizLico form = new EditFizLico();
            form.Show();
        }

        private void OpenEditUrLico(object sender, RoutedEventArgs e)
        {
            EditUrLico form = new EditUrLico();
            form.Show();
        }

        private void OpenEditPostavleno(object sender, RoutedEventArgs e)
        {
            EditPostavleno form = new EditPostavleno();
            form.Show();
        }

        private void OpenDeletePostavshik(object sender, RoutedEventArgs e)
        {
            DeletePostavshik form = new DeletePostavshik();
            form.Show();
        }

        private void OpenDeleteDogovor(object sender, RoutedEventArgs e)
        {
            DeleteDogovor form = new DeleteDogovor();
            form.Show();
        }

        private void OpenDeleteFizLico(object sender, RoutedEventArgs e)
        {
            DeleteFizLico form = new DeleteFizLico();
            form.Show();
        }

        private void OpenDeleteUrLico(object sender, RoutedEventArgs e)
        {
            DeleteUrLico form = new DeleteUrLico();
            form.Show();
        }

        private void OpenDeletePostavleno(object sender, RoutedEventArgs e)
        {
            DeletePostavleno form = new DeletePostavleno();
            form.Show();
        }
    }
}
