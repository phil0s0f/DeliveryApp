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
    /// Логика взаимодействия для EditUrLico.xaml
    /// </summary>
    public partial class EditUrLico : Window
    {
        deliveryEntities context;
        public EditUrLico()
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

        private void EditClick(object sender, RoutedEventArgs e)
        {
            ЮридическиеЛица urlico = KodPostavshikBox.SelectedItem as ЮридическиеЛица;
            context.ЮридическиеЛица.Find(urlico.КодПоставщика).Название = NameBox.Text;
            context.ЮридическиеЛица.Find(urlico.КодПоставщика).НалоговыйНомер = NalogNomerBox.Text;
            context.ЮридическиеЛица.Find(urlico.КодПоставщика).НомерСвидетельстваНДС = NomerSvidNdsBox.Text;
            context.SaveChanges();
            MessageBox.Show("Данные успешно изменены");
        }
    }
}
