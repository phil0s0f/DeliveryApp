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
    /// Логика взаимодействия для DeleteDogovor.xaml
    /// </summary>
    public partial class DeleteDogovor : Window
    {
        deliveryEntities context;
        public DeleteDogovor()
        {
            InitializeComponent();
            context = new deliveryEntities();
            NomerDogovoraBox.ItemsSource = context.Договоры.ToList();
        }

        private void ChangeDogovor(object sender, SelectionChangedEventArgs e)
        {
            Договоры dogovor = NomerDogovoraBox.SelectedItem as Договоры;
            DateDogovoraBox.Text = Convert.ToString(dogovor.ДатаДоговора);
            KodPostavshikBox.Text = Convert.ToString(dogovor.КодПоставщика);
            CommentBox.Text = dogovor.Комментарий;
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Договоры dogovor = NomerDogovoraBox.SelectedItem as Договоры;
            context.Договоры.Remove(dogovor);
            context.SaveChanges();
        }
    }
}
