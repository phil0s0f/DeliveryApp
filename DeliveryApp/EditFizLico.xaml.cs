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
    /// Логика взаимодействия для EditFizLico.xaml
    /// </summary>
    public partial class EditFizLico : Window
    {
        deliveryEntities context;
        public EditFizLico()
        {
            InitializeComponent();
            context = new deliveryEntities();
            KodPostavshikBox.ItemsSource = context.ФизическиеЛица.ToList();
        }

        private void ChangeFizLico(object sender, SelectionChangedEventArgs e)
        {
            ФизическиеЛица fizlico = KodPostavshikBox.SelectedItem as ФизическиеЛица;
            FamBox.Text = fizlico.Фамилия;
            NameBox.Text = fizlico.Имя;
            OtchBox.Text = fizlico.Отчество;
            NomerSvidBox.Text = fizlico.НомерСвидетельства;
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            ФизическиеЛица fizlico = KodPostavshikBox.SelectedItem as ФизическиеЛица;
            context.ФизическиеЛица.Find(fizlico.КодПоставщика).Фамилия = FamBox.Text;
            context.ФизическиеЛица.Find(fizlico.КодПоставщика).Имя = NameBox.Text;
            context.ФизическиеЛица.Find(fizlico.КодПоставщика).Отчество = OtchBox.Text;
            context.ФизическиеЛица.Find(fizlico.КодПоставщика).НомерСвидетельства = NomerSvidBox.Text;
            context.SaveChanges();
        }
    }
}
