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
    /// Логика взаимодействия для AddUrLico.xaml
    /// </summary>
    public partial class AddUrLico : Window
    {
        public AddUrLico()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            deliveryEntities context = new deliveryEntities();
            ЮридическиеЛица urlico = new ЮридическиеЛица();
            urlico.КодПоставщика = Convert.ToInt32(KodPostavshikBox.Text);
            urlico.Название = NameBox.Text;
            urlico.НалоговыйНомер = NalogNomerBox.Text;
            urlico.НомерСвидетельстваНДС = NomerSvidNdsBox.Text;
            context.ЮридическиеЛица.Add(urlico);
            context.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
            KodPostavshikBox.Text = NameBox.Text = NalogNomerBox.Text = NomerSvidNdsBox.Text = "";
        }
    }
}
