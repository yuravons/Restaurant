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

namespace Restaurant.Waiter
{
    /// <summary>
    /// Логика взаимодействия для AddMenu.xaml
    /// </summary>
    public partial class AddMenu : Window
    {
        Project_Restaurant1Entities _db = new Project_Restaurant1Entities();
        public List<int> id_menu;
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            MenuTable m = DataGridMenu.SelectedItem as MenuTable;
            MessageBox.Show("Ви замовили - " + m.name + " за " + m.price + " грн");
        }
        public AddMenu()
        {
            InitializeComponent();
            
            Style rowStyle = new Style(typeof(DataGridRow));
            rowStyle.Setters.Add(new EventSetter(DataGridRow.MouseDoubleClickEvent,
                                     new MouseButtonEventHandler(Row_DoubleClick)));
            DataGridMenu.RowStyle = rowStyle;
            DataGridMenu.ItemsSource = GetMenu();
        }
        private class MenuTable
        {
            public int id { get; set; }
            public string type_dish { get; set; }
            public string name { get; set; }
            public int size { get; set; }
            public string unit_measurement { get; set; }
            public int price { get; set; }
        }
        List<MenuTable> GetMenu()
        {
            var menu = (from menu_item in _db.menu
                         join type_item in _db.type_dish on menu_item.type_dish_id equals type_item.id
                         join unit_item in _db.units_of_measurement on menu_item.unit_of_measurement_id equals unit_item.id
                         select new MenuTable
                         {
                             id = menu_item.id,
                             size = menu_item.size,
                             name = menu_item.dish_name,
                             type_dish = type_item.type,
                             unit_measurement = unit_item.name,
                             price = menu_item.price
                         }).Distinct();
            
            return menu.OrderBy(x => x.type_dish).ToList();
        }
        private void DataGridMenu_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
