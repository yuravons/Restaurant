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
using System.Windows.Shapes;
using System.Timers;
using Restaurant.Waiter;

namespace Restaurant.Waiter
{
    /// <summary>
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    /// 

    public partial class AddOrder : Window
    {
        Project_Restaurant1Entities _db = new Project_Restaurant1Entities();
        public AddOrder()
        {
            InitializeComponent();
            InitializeWaiters();
            InitializePersons();
        }

        public void InitializeWaiters()
        {
            List<waiters> wts = _db.waiters.ToList();
            ComboboxWaiters.ItemsSource = wts;
        }

        public void InitializePersons()
        {
            List<int> persons = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            ComboboxCountPersons.ItemsSource = persons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int status = 1;
            string table;
            int id_table;
            int id_waiter;
            int person = Convert.ToInt32(ComboboxCountPersons.Text);
            if (person == 1)
                table = (_db.platens.
                    Where(x => x.people_amount >= 2).
                    Select(x => x.id).FirstOrDefault()).ToString();
            else
                table = (_db.platens.
                    Where(x => x.people_amount == person).
                    Select(x => x.id).FirstOrDefault()).ToString();
            string w_name = ComboboxWaiters.Text;
            var waiter = (_db.waiters.
                Where(x => x.name == w_name).
                Select(x => x.id).FirstOrDefault()).ToString();
            id_waiter = Convert.ToInt32(waiter);
            id_table = Convert.ToInt32(table);
            orders order = new orders { time = DateTime.Now.ToLocalTime(), status_id = status, table_id = id_table, waiter_id = id_waiter };
            _db.orders.Add(order);
            _db.SaveChanges();
            
        }

        private class CheckTable
        {
            public int name { get; set; }
            public int counter { get; set; }
            public int id { get; set; }
            public int id_table { get; set; }
            public string waiter_name { get; set; }
            public string dishname { get; set; }
            public int size { get; set; }
            public string unit_measurement { get; set; }
            public int price { get; set; }
            public int count { get; set; }
            public int ToPay { get; set; }
            public int id_order { get; set; }
        }
        List<CheckTable> GetCurrentCheck()
        {
            var check = (from check_item in _db.checks
                         join menu_item in _db.menu on check_item.menu_id equals menu_item.id
                         join order_item in _db.orders on check_item.order_id equals order_item.id
                         join waiter_item in _db.waiters on order_item.waiter_id equals waiter_item.id
                         join platen_item in _db.platens on order_item.table_id equals platen_item.id
                         join unit_item in _db.units_of_measurement on menu_item.unit_of_measurement_id equals unit_item.id
                         
                         group check_item by check_item.order_id into g
                         
                         select new CheckTable
                         {
                             
                             name = g.Key,
                             counter = g.Count()
                             
                         });
            return check.ToList();
        }
        List<CheckTable> GetCheck()
        {
            string w_name = ComboboxWaiters.Text;
            var check = (from check_item in _db.checks
                         join menu_item in _db.menu on check_item.menu_id equals menu_item.id
                         join order_item in _db.orders on check_item.order_id equals order_item.id
                         join waiter_item in _db.waiters on order_item.waiter_id equals waiter_item.id
                         join platen_item in _db.platens on order_item.table_id equals platen_item.id
                         join unit_item in _db.units_of_measurement on menu_item.unit_of_measurement_id equals unit_item.id
                         where waiter_item.name == w_name 
                         select new CheckTable
                         {
                             id = check_item.id,
                             id_table = platen_item.number,
                             waiter_name = waiter_item.name,
                             dishname = menu_item.dish_name,
                             size = menu_item.size,
                             unit_measurement = unit_item.name,
                             price = menu_item.price,
                             count = check_item.count,
                             ToPay = menu_item.price * check_item.count
                         }).Distinct();

            return check.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddMenu menuPage = new AddMenu();
            menuPage.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //DataGridChecks.ItemsSource = GetCurrentCheck();
            DataGridChecks.ItemsSource = GetCheck();
        }
    }
}
