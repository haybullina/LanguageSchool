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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        private bool IsAdmin = false;
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EventLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TxtPassword.Password == "0000")
            {
                IsAdmin = true;
                NavigationService.Navigate(new ListOfServices(IsAdmin));
            }
            else 
            {
                IsAdmin = false;
                NavigationService.Navigate(new ListOfServices(IsAdmin));
            }
        }
    }
}
