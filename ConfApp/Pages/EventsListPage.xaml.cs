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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для EventsListPage.xaml
    /// </summary>
    public partial class EventsListPage : Page
    {
        public EventsListPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            EventListView.ItemsSource = Data.User1212Entities.GetContext().Event.ToList();
        }

        private void SearchEventTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.AuthorizationPage());
        }
    }
}
