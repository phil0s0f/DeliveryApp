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

namespace DeliveryApp
{
    /// <summary>
    /// Логика взаимодействия для DeletePostavleno.xaml
    /// </summary>
    public partial class DeletePostavleno : Window
    {
        deliveryEntities context;
        public DeletePostavleno()
        {
            InitializeComponent();
            context = new deliveryEntities();
            NomerDogovoraBox.ItemsSource = context.Поставлено.ToList();
        }

        private void ChangePostavleno(object sender, SelectionChangedEventArgs e)
        {
            Поставлено post = NomerDogovoraBox.SelectedItem as Поставлено;
            TovarBox.Text = post.Товар;
            KolichestvoBox.Text = Convert.ToString(post.Количество);
            CenaBox.Text = Convert.ToString(post.Цена);
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Поставлено post = NomerDogovoraBox.SelectedItem as Поставлено;
            context.Поставлено.Remove(post);
            context.SaveChanges();
        }
    }
}
