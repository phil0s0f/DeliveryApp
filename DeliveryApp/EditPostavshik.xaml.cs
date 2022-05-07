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
    /// Логика взаимодействия для EditPostavshik.xaml
    /// </summary>
    public partial class EditPostavshik : Window
    {
        deliveryEntities context;
        public EditPostavshik()
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

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Поставщики post = KodPostavBox.SelectedItem as Поставщики;
            context.Поставщики.Find(post.КодПоставщика).Адрес = AdresBox.Text;
            context.Поставщики.Find(post.КодПоставщика).Примечание = CommentBox.Text;
            context.SaveChanges();
            MessageBox.Show("Данные успешно изменены");
        }
    }
}
