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
    /// Логика взаимодействия для AddDogovor.xaml
    /// </summary>
    public partial class AddDogovor : Window
    {
        public AddDogovor()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            deliveryEntities context = new deliveryEntities();
            Договоры dogovor = new Договоры();
            dogovor.НомерДоговора = Convert.ToInt32(NomerDogovoraBox.Text);
            dogovor.ДатаДоговора = Convert.ToDateTime(NomerDogovoraBox.Text);
            dogovor.КодПоставщика = Convert.ToInt32(KodPostavshikBox.Text);
            dogovor.Комментарий = CommentBox.Text;
            context.Договоры.Add(dogovor);
            context.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
            NomerDogovoraBox.Text = NomerDogovoraBox.Text = KodPostavshikBox.Text = CommentBox.Text = "";
        }
    }
}
