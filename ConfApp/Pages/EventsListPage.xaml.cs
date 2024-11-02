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
            Update();
            myDatePicker.SelectedDate = DateTime.Now;
        }
        public void Init()
        {
            try
            {
                EventListView.ItemsSource = Data.User1212Entities.GetContext().Event.ToList();
            }
            catch
            {

            }
        }

        public List<Data.Event> _events = Data.User1212Entities.GetContext().Event.ToList();

        public void Update()
        {
            try
            {
                _events = Data.User1212Entities.GetContext().Event.ToList();

                if (!string.IsNullOrEmpty(SearchEventTextBox.Text))
                {
                    _events = (from item in Data.User1212Entities.GetContext().Event.ToList()
                                 where item.EventName.Name.ToLower().Contains(SearchEventTextBox.Text.ToLower()) ||
                                 item.Direction.NameDirection.ToLower().Contains(SearchEventTextBox.Text.ToLower())
                                 select item).ToList();
                }

                EventListView.ItemsSource = _events;
            }
            catch
            {

            }
        }

        private void SearchEventTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = Convert.ToDateTime(myDatePicker.SelectedDate).ToShortDateString;
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.AuthorizationPage());
        }
    }
}
