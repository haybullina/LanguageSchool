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
            var count = 0;
            foreach (var i in TbxTime.Text)
            {
                var j = 0;
                if (!(i.ToString() == ":" || int.TryParse(i.ToString(), out j)))
                {
                    MessageBox.Show("Были введены лишние символы");
                    TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 1, 1);
                    return;
                }
                if (int.TryParse(i.ToString(), out j))
                {
                    count++;
                }
                if (count > 2)
                {
                    MessageBox.Show("Были введены лишние символы");
                    TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 1, 1);
                    return;
                }
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TbxTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            var count = 0;
            string number = "0";
            foreach (var i in TbxTime.Text)
            {
                var j = 0;
                if (!(i.ToString() == ":" || int.TryParse(i.ToString(), out j)))
                {
                    MessageBox.Show("Были введены лишние символы");
                    TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 1, 1);
                    return;
                }
                if (int.TryParse(i.ToString(), out j))
                {
                    count++;
                    number += TbxTime.Text[TbxTime.Text.Length - 1];
                }
                if (i.ToString() == ":" && TbxTime.Text[2] == ':')
                {
                    count = 0;
                    number = "";
                }
                if (TbxTime.Text.Length >= 2)
                {
                    if (TbxTime.Text[1] == ':')
                    {
                        TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 1, 1);
                        MessageBox.Show("Формат хх:хх");
                    }
                }
                if (count == 2 && Int32.Parse(number) > 23)
                {
                    MessageBox.Show("Время некоректно");
                    TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 2, 2);
                    number = "";
                    count = 0;
                    return;
                }
                if (count > 2)
                {
                    count = -1;
                    MessageBox.Show("Были введены лишние символы");
                    TbxTime.Text = TbxTime.Text.Remove(TbxTime.Text.Length - 1, 1);
                    return;
                }
            }
        }
    }
}
