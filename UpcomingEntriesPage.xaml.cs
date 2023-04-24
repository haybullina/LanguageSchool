using LearnLanguageSchool.AdoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace LearnLanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для UpcomingEntriesPage.xaml
    /// </summary>
    public partial class UpcomingEntriesPage : Page
    {
        List<ClientService> clientServices = new List<ClientService>();
        public UpcomingEntriesPage()
        {
            InitializeComponent();

            DateTime timeTwoDays = DateTime.Now + new TimeSpan(2,0,0,0);
            clientServices = DBConnection.Connection.ClientService.Where(n => n.StartTime > DateTime.Now && n.StartTime < timeTwoDays).ToList();

            ListItems.ItemsSource = clientServices;
        }

        async Task RefreshPageAsync() 
        {
            while (true) 
            {
                Thread.Sleep(30000);
                this.NavigationService.Refresh();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


    }
}
