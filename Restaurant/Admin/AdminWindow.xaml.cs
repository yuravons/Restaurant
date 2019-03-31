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
using System.Data.Entity.Core;

namespace Restaurant.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        Project_Restaurant1Entities db = new Project_Restaurant1Entities();
        public AdminWindow()
        {
            InitializeComponent();
            typesDishesGrid.ItemsSource = db.type_dish.ToList();
            statusesGrid.ItemsSource = db.statuses.ToList();
            waitersGrid.ItemsSource = db.waiters.ToList();
        }

        //type_dish add
        private void AddTypeDish_Click(object sender, RoutedEventArgs e)
        {
            AddTypeDish dishWindow = new AddTypeDish();
            dishWindow.ShowDialog();
            typesDishesGrid.ItemsSource = db.type_dish.ToList();
        }
        //type_dish delete
        private void deleteTypeBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmReadiness confWindow = new ConfirmReadiness("Ви підтверджуєте видалення типу страви?");
            if (confWindow.ShowDialog() == true)
            {
                int id = (typesDishesGrid.SelectedItem as type_dish).id;
                var deleteTypeDish = db.type_dish.Where(m => m.id == id).Single();
                db.type_dish.Remove(deleteTypeDish);
                db.SaveChanges();
                typesDishesGrid.ItemsSource = db.type_dish.ToList();
            }
            else
            {
                confWindow.Hide();
            }
        }
        //type_dish update
        private void updateTypeDishBtn_Click(object sender, RoutedEventArgs e)
        {
            type_dish type_dish = (typesDishesGrid.SelectedItem as type_dish);
            type_dish thisTypeDish = db.getTypeDishInfo(type_dish.id).Single();
            thisTypeDish.type = type_dish.type;
            db.SaveChanges();
            typesDishesGrid.ItemsSource = db.type_dish.ToList();
            MessageBox.Show("Зміни успішно збережено");
        }

        //status add
        private void AddStatus_Click(object sender, RoutedEventArgs e)
        {
            AddStatus statusWindow = new AddStatus();
            statusWindow.ShowDialog();
            statusesGrid.ItemsSource = db.statuses.ToList();
        }
        //status delete
        private void deleteStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmReadiness confWindow = new ConfirmReadiness("Ви підтверджуєте видалення статусу?");
            if (confWindow.ShowDialog() == true)
            {
                int id = (statusesGrid.SelectedItem as statuses).id;
                var deleteStatus = db.statuses.Where(m => m.id == id).Single();
                db.statuses.Remove(deleteStatus);
                db.SaveChanges();
                statusesGrid.ItemsSource = db.statuses.ToList();
            }
            else
            {
                confWindow.Hide();
            }
        }
        //status update
        private void updateStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            statuses status = (statusesGrid.SelectedItem as statuses);
            statuses thisStatus = db.getStatusInfo(status.id).Single();
            thisStatus.name = status.name;
            db.SaveChanges();
            statusesGrid.ItemsSource = db.statuses.ToList();
            MessageBox.Show("Зміни успішно збережено");
        }

        //Waiter add
        private void AddWaiterBtn_Click(object sender, RoutedEventArgs e)
        {
            AddWaiter waiterWindow = new AddWaiter();
            waiterWindow.ShowDialog();
            waitersGrid.ItemsSource = db.waiters.ToList();
        }
        //Waiter delete
        private void deleteWaiterBtn_Click(object sender, RoutedEventArgs e)
        {
            ConfirmReadiness confWindow = new ConfirmReadiness("Ви підтверджуєте видалення офіціанта?");
            if (confWindow.ShowDialog() == true)
            {
                int id = (waitersGrid.SelectedItem as waiters).id;
                var deleteWaiter = db.waiters.Where(m => m.id == id).Single();
                db.waiters.Remove(deleteWaiter);
                db.SaveChanges();
                waitersGrid.ItemsSource = db.waiters.ToList();
            }
            else
            {
                confWindow.Hide();
            }
        }
        //Waiter update
        private void updateWaiterBtn_Click(object sender, RoutedEventArgs e)
        {
            waiters waiter = (waitersGrid.SelectedItem as waiters);
            waiters thisWaiter = db.getWaiterInfo(waiter.id).Single();
            thisWaiter.name = waiter.name;
            db.SaveChanges();
            waitersGrid.ItemsSource = db.waiters.ToList();
            MessageBox.Show("Зміни успішно збережено");
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
            {
                this.Close();
            }
            else
            {
                confWindow.Hide();
            }
        }
    }
}
