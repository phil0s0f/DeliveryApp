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
    /// Логика взаимодействия для AddPostavshik.xaml
    /// </summary>
    public partial class AddPostavshik : Window
    {
        public AddPostavshik()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            deliveryEntities context = new deliveryEntities();
            Поставщики postav = new Поставщики();
            postav.КодПоставщика = Convert.ToInt32(KodPostavBox.Text);
            postav.Адрес = AdresBox.Text;
            postav.Примечание = CommentBox.Text;
            context.Поставщики.Add(postav);
            context.SaveChanges();
        }
    }
}
