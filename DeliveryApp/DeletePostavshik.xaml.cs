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
    /// Логика взаимодействия для DeletePostavshik.xaml
    /// </summary>
    public partial class DeletePostavshik : Window
    {
        deliveryEntities context;
     
        public DeletePostavshik()
        {
            InitializeComponent();
            context = new deliveryEntities();
            KodPostavBox.ItemsSource = context.Поставщики.ToList();
        }

        private void ChangePostav(object sender, SelectionChangedEventArgs e)
        {
            Поставщики post = KodPostavBox.SelectedItem as Поставщики;
            AdresBox.Text = post.Адрес;
            CommentBox.Text = post.Примечание;
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Поставщики post = KodPostavBox.SelectedItem as Поставщики;
            context.Поставщики.Remove(post);
            context.SaveChanges();
        }
    }
}
