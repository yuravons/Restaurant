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

namespace Restaurant.Provider
{
    /// <summary>
    /// Логика взаимодействия для AddProvider.xaml
    /// </summary>
    public partial class AddProvider : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AddProvider()
        {
            InitializeComponent();
        }

        private void AddProviderBtn_Click(object sender, RoutedEventArgs e)
        {
            providers newItem = new providers()
            {
                name = ProviderNameTextBox.Text
            };
            db.providers.Add(newItem);
            db.SaveChanges();
            this.Hide();
        }
    }
}
