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
    /// Логика взаимодействия для DeleteFizLico.xaml
    /// </summary>
    public partial class DeleteFizLico : Window
    {
        deliveryEntities context;
        public DeleteFizLico()
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

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            ФизическиеЛица fizlico = KodPostavshikBox.SelectedItem as ФизическиеЛица;
            context.ФизическиеЛица.Remove(fizlico);
            context.SaveChanges();
        }
    }
}
