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
    /// Логика взаимодействия для ViewPostavleno.xaml
    /// </summary>
    public partial class ViewPostavleno : Window
    {
        public ViewPostavleno()
        {
            InitializeComponent();
            deliveryEntities context = new deliveryEntities();
            List<Поставлено> postavleno = context.Поставлено.ToList();
            dataPostavleno.ItemsSource = postavleno;
        }
    }
}
