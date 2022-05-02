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
    /// Логика взаимодействия для AddPostavleno.xaml
    /// </summary>
    public partial class AddPostavleno : Window
    {
        public AddPostavleno()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            deliveryEntities context = new deliveryEntities();
            Поставлено postavleno = new Поставлено();
            postavleno.НомерДоговора = Convert.ToInt32(NomerDogovoraBox.Text);
            postavleno.Товар = TovarBox.Text;
            postavleno.Количество = Convert.ToInt32(KolichestvoBox.Text);
            postavleno.Цена = Convert.ToDecimal(CenaBox.Text);
            context.Поставлено.Add(postavleno);
            context.SaveChanges();
        }
    }
}
