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
    /// Логика взаимодействия для DeleteUrLico.xaml
    /// </summary>
    public partial class DeleteUrLico : Window
    {
        deliveryEntities context;
        public DeleteUrLico()
        {
            InitializeComponent();
            context = new deliveryEntities();
            KodPostavshikBox.ItemsSource = context.ЮридическиеЛица.ToList();
        }

        private void ChangeUrLico(object sender, SelectionChangedEventArgs e)
        {
            ЮридическиеЛица urlico = KodPostavshikBox.SelectedItem as ЮридическиеЛица;
            NameBox.Text = urlico.Название;
            NalogNomerBox.Text = urlico.НалоговыйНомер;
            NomerSvidNdsBox.Text = urlico.НомерСвидетельстваНДС;
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            ЮридическиеЛица urlico = KodPostavshikBox.SelectedItem as ЮридическиеЛица;
            context.ЮридическиеЛица.Remove(urlico);
            context.SaveChanges();
        }
    }
}
