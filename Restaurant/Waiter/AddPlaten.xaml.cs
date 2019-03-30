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

namespace Restaurant.Waiter
{
    /// <summary>
    /// Логика взаимодействия для AddPlaten.xaml
    /// </summary>
    public partial class AddPlaten : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AddPlaten()
        {
            InitializeComponent();
        }

        private void AddTableBtn_Click(object sender, RoutedEventArgs e)
        {
            platens newItem = new platens()
            {
                number = Convert.ToInt32(NumberTableTextBox.Text),
                people_amount = Convert.ToInt32(CountPersonsTextBox.Text)
            };
            db.platens.Add(newItem);
            db.SaveChanges();
            this.Hide();
        }
    }
}
