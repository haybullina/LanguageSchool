using LearnLanguageSchool.AdoModel;
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

namespace LearnLanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecordingPage.xaml
    /// </summary>
    public partial class RecordingPage : Page
    {
        Service service;
        public RecordingPage(Service service)
        {
            InitializeComponent();
            this.service = service;
            TxName.Text = this.service.Title;
            TxDurationInSeconds.Text = $"Длительность урока: {(this.service.DurationInSeconds / 60)} мин.";

            foreach (var client in DBConnection.Connection.Client.ToList())
            CbClients.Items.Add(client);

            //DBConnection.Connection.ClientService.Add(new ClientService());
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var count = 0;
                if (TbxTime.Text.Length > 5 && TbxTime.Text.Length < 5)
                {
                    MessageBox.Show("Неправильный формат времени");
                    return;
                }

                if (CbClients.SelectedItem == null)
                {
                    MessageBox.Show("Клиент не выбран");
                    return;
                }

                int timeHour = Int32.Parse($"{TbxTime.Text[0]}{TbxTime.Text[1]}");
                int timeMinute = Int32.Parse($"{TbxTime.Text[3]}{TbxTime.Text[4]}");

                ClientService clientService = new ClientService()
                {
                    ClientID = (CbClients.SelectedItem as Client).ID,
                    ServiceID = service.ID,
                    StartTime = (DateTime)TbxDate.SelectedDate + new TimeSpan(timeHour, timeMinute, 0),
                };
                DBConnection.Connection.ClientService.Add(clientService);
                DBConnection.Connection.SaveChanges();
                MessageBox.Show("Готово");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
