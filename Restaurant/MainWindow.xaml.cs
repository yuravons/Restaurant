using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Restaurant.Waiter;

namespace Restaurant
{
    public class waiter
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class WaiterContext : DbContext
    {
        public WaiterContext() : base ("DefaultConnection")
        {

        }
        public DbSet<waiter> waiters { get; set; }
    }


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WaiterContext db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new WaiterContext();
            db.waiters.Load();
            DataGridWaiters.GridLinesVisibility = DataGridGridLinesVisibility.None;
            DataGridWaiters.ItemsSource = db.waiters.Local.ToBindingList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddOrder orderPage = new AddOrder();
            orderPage.ShowDialog();
        }

        private void Button_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("hello");
        }
    }
}
