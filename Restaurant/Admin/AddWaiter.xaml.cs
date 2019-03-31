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
    /// Логика взаимодействия для AddWaiter.xaml
    /// </summary>
    public partial class AddWaiter : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AddWaiter()
        {
            InitializeComponent();
        }

        private void AddWaiterBtn_Click(object sender, RoutedEventArgs e)
        {
            waiters newItem = new waiters()
            {
                name = WaiterNameTextBox.Text
            };
            db.waiters.Add(newItem);
            db.SaveChanges();
            this.Hide();
        }
        private void Change_User(object sender, RoutedEventArgs e)
        {
            LoginScreen window = new LoginScreen();
            window.ShowDialog();
            this.Close();
        }
        private void Help_Item(object sender, RoutedEventArgs e)
        {

        }
        private void About_Item(object sender, RoutedEventArgs e)
        {
            AboutProgram window = new AboutProgram();
            window.ShowDialog();
        }
        private void Close_Program(object sender, RoutedEventArgs e)
        {
            ConfirmReadiness confWindow = new ConfirmReadiness("Ви впевнені, що хочете вийти?");
            if (confWindow.ShowDialog() == true)
                this.Close();
            else
                confWindow.Hide();
        }
    }
}
