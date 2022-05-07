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
    /// Логика взаимодействия для EditDogovor.xaml
    /// </summary>
    public partial class EditDogovor : Window
    {
        deliveryEntities context;
        public EditDogovor()
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

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Договоры dogovor = NomerDogovoraBox.SelectedItem as Договоры;
            context.Договоры.Find(dogovor.НомерДоговора).ДатаДоговора = Convert.ToDateTime(DateDogovoraBox.Text);
            context.Договоры.Find(dogovor.НомерДоговора).КодПоставщика = Convert.ToInt32(KodPostavshikBox.Text);
            context.Договоры.Find(dogovor.НомерДоговора).Комментарий = CommentBox.Text;
            context.SaveChanges();
            MessageBox.Show("Данные успешно изменены");
        }
    }
}
