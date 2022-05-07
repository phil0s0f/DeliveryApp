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
    /// Логика взаимодействия для EditPostavleno.xaml
    /// </summary>
    public partial class EditPostavleno : Window
    {
        deliveryEntities context;
        public EditPostavleno()
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

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Поставлено post = NomerDogovoraBox.SelectedItem as Поставлено;
            context.Поставлено.Find(post.НомерДоговора).Товар = TovarBox.Text;
            context.Поставлено.Find(post.НомерДоговора).Количество = Convert.ToInt32(KolichestvoBox.Text);
            context.Поставлено.Find(post.НомерДоговора).Цена = Convert.ToDecimal(CenaBox.Text);
            context.SaveChanges();
            MessageBox.Show("Данные успешно изменены");
        }


    }
}
