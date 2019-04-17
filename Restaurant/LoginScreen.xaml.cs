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
using Restaurant.Provider;
using Restaurant.Waiter;
using Restaurant.Admin;

namespace Restaurant
{
    /// <summary>
    /// Логика взаимодействия для LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var user = db.users.FirstOrDefault(x => x.login == txtUsername.Text && x.password == txtPassword.Password);
            if (user != null && user.login == "manager")
            {
                ProviderWindow prWindow = new ProviderWindow();
                prWindow.Show();
                this.Close();
            }
            else if (user != null && user.login == "admin")
            {
                AdminWindow adWindow = new AdminWindow();
                adWindow.Show();
                this.Close();
            }
            else if (user != null && user.login == "waiter")
            {
                WaiterWindow waWindow = new WaiterWindow();
                waWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("The user doesn't exist");
            }
        }
    }
}
