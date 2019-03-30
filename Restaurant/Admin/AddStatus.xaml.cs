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

namespace Restaurant.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddStatus.xaml
    /// </summary>
    public partial class AddStatus : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AddStatus()
        {
            InitializeComponent();
        }

        private void AddStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            statuses newItem = new statuses()
            {
                name = statusTextBox.Text
            };
            db.statuses.Add(newItem);
            db.SaveChanges();
            this.Hide();
        }
    }
}
