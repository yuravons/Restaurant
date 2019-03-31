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
    /// Логика взаимодействия для AddStorageItem.xaml
    /// </summary>
    public partial class AddStorageItem : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        int unit_id;
        public AddStorageItem()
        {
            InitializeComponent();
            List<units_of_measurement> units = db.units_of_measurement.ToList();
            unitComboBox.ItemsSource = units;
        }
        private void UnitComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            unit_id = Convert.ToInt32(unitComboBox.SelectedValue);
        }

        private void AddStorageItemBtn_Click(object sender, RoutedEventArgs e)
        {
            ingredients newItem = new ingredients()
            {
                name = StorageItemNameTextBox.Text
            };
            db.ingredients.Add(newItem);
            db.SaveChanges();
            storage_ingredient newItem2 = new storage_ingredient()
            {
                count = 0,
                ingredient_id = (from m in db.ingredients select m.id).ToList().Last(),
                unit_of_measurement_id = unit_id
            };
            db.storage_ingredient.Add(newItem2);
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
