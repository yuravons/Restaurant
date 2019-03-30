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
    /// Логика взаимодействия для AddTypeDish.xaml
    /// </summary>
    public partial class AddTypeDish : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AddTypeDish()
        {
            InitializeComponent();
        }

        private void AddTypeDishBtn_Click(object sender, RoutedEventArgs e)
        {
            type_dish newItem = new type_dish()
            {
                type = typeDishTextBox.Text
            };
            db.type_dish.Add(newItem);
            db.SaveChanges();
            this.Hide();
        }
    }
}
