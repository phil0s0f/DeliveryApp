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
    /// Логика взаимодействия для AddFizLico.xaml
    /// </summary>
    public partial class AddFizLico : Window
    {
        public AddFizLico()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            deliveryEntities context = new deliveryEntities();
            ФизическиеЛица fizlico = new ФизическиеЛица();
            fizlico.КодПоставщика = Convert.ToInt32(KodPostavshikBox.Text);
            fizlico.Фамилия = FamBox.Text;
            fizlico.Имя = NameBox.Text;
            fizlico.Отчество = OtchBox.Text;
            fizlico.НомерСвидетельства = NomerSvidBox.Text;
            context.ФизическиеЛица.Add(fizlico);
            context.SaveChanges();
        }
    }
}
