using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using LearnLanguageSchool.AdoModel;

namespace LearnLanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOfServices.xaml
    /// </summary>
    public partial class ListOfServices : Page
    {
        private bool IsAdmin;
        private List<Service> Services;
        public ListOfServices(bool IsAdmin)
        {
            InitializeComponent();

            this.IsAdmin = IsAdmin;
            
            Services = DBConnection.Connection.Service.ToList();

            if (!IsAdmin)
            {
                ListItems.Visibility = Visibility.Visible;
                ListItemsAdmin.Visibility = Visibility.Collapsed;
                ListItems.ItemsSource = Services;

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
            }
            else if (IsAdmin)
            {
                ListItemsAdmin.Visibility = Visibility.Visible;
                ListItems.Visibility = Visibility.Collapsed;
                ListItemsAdmin.ItemsSource = Services;

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
            }
            Search.Text = "";
        }

        private void CmbxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsAdmin)
            {
                var item = (CmbxSort.SelectedItem as ComboBoxItem).Content.ToString();

                if (item == "По возрастанию")
                {
                    Services = Services.OrderBy(n => n.Title).ToList();
                    ListItems.ItemsSource = Services;
                }
                else if (item == "По убыванию")
                {
                    Services = Services.OrderByDescending(n => n.Title).ToList();
                    ListItems.ItemsSource = Services;
                }

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
            }
            else if (IsAdmin)
            {
                var item = (CmbxSort.SelectedItem as ComboBoxItem).Content.ToString();

                if (item == "По возрастанию")
                {
                    Services = Services.OrderBy(n => n.Title).ToList();
                    ListItemsAdmin.ItemsSource = Services;

                }
                else if (item == "По убыванию")
                {
                    Services = Services.OrderByDescending(n => n.Title).ToList();
                    ListItemsAdmin.ItemsSource = Services;
                }

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
            }
        }

        private void CmbxDiscountRange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Search.Text == null || Search.Text == "")
            {
                if (!IsAdmin)
                {
                    var item = (CmbxDiscountRange.SelectedItem as ComboBoxItem).Content.ToString();

                    if (item == "Все")
                    {
                        Services = DBConnection.Connection.Service.ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 0% до 5%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount == 0 && n.Discount < 5).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 5% до 15%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 5 && n.Discount < 15).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 15% до 30%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 15 && n.Discount < 30).ToList();
                        ListItems.ItemsSource = Services;

                    }
                    else if (item == "от 30% до 70%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 30 && n.Discount < 70).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 70% до 100%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 70 && n.Discount < 100).ToList();
                        ListItems.ItemsSource = Services;
                    }

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
                else if (IsAdmin)
                {
                    var item = (CmbxDiscountRange.SelectedItem as ComboBoxItem).Content.ToString();

                    if (item == "Все")
                    {
                        Services = DBConnection.Connection.Service.ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 0% до 5%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount == 0 && n.Discount < 5).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 5% до 15%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 5 && n.Discount < 15).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 15% до 30%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 15 && n.Discount < 30).ToList();
                        ListItemsAdmin.ItemsSource = Services;

                    }
                    else if (item == "от 30% до 70%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 30 && n.Discount < 70).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 70% до 100%")
                    {
                        Services = DBConnection.Connection.Service.Where(n => n.Discount >= 70 && n.Discount < 100).ToList();
                        ListItems.ItemsSource = Services;
                    }

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
            }
            else if (Search.Text != "" || Search.Text != null) 
            {
                if (!IsAdmin)
                {
                    var item = (CmbxDiscountRange.SelectedItem as ComboBoxItem).Content.ToString();

                    if (item == "Все")
                    {
                        Services = DBConnection.Connection.Service.ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 0% до 5%")
                    {
                        Services = Services.Where(n => n.Discount == 0 && n.Discount < 5).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 5% до 15%")
                    {
                        Services = Services.Where(n => n.Discount >= 5 && n.Discount < 15).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 15% до 30%")
                    {
                        Services = Services.Where(n => n.Discount >= 15 && n.Discount < 30).ToList();
                        ListItems.ItemsSource = Services;

                    }
                    else if (item == "от 30% до 70%")
                    {
                        Services = Services.Where(n => n.Discount >= 30 && n.Discount < 70).ToList();
                        ListItems.ItemsSource = Services;
                    }
                    else if (item == "от 70% до 100%")
                    {
                        Services = Services.Where(n => n.Discount >= 70 && n.Discount < 100).ToList();
                        ListItems.ItemsSource = Services;
                    }

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
                else if (IsAdmin)
                {
                    var item = (CmbxDiscountRange.SelectedItem as ComboBoxItem).Content.ToString();

                    if (item == "Все")
                    {
                        Services = Services.ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 0% до 5%")
                    {
                        Services = Services.Where(n => n.Discount == 0 && n.Discount < 5).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 5% до 15%")
                    {
                        Services = Services.Where(n => n.Discount >= 5 && n.Discount < 15).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 15% до 30%")
                    {
                        Services = Services.Where(n => n.Discount >= 15 && n.Discount < 30).ToList();
                        ListItemsAdmin.ItemsSource = Services;

                    }
                    else if (item == "от 30% до 70%")
                    {
                        Services = Services.Where(n => n.Discount >= 30 && n.Discount < 70).ToList();
                        ListItemsAdmin.ItemsSource = Services;
                    }
                    else if (item == "от 70% до 100%")
                    {
                        Services = Services.Where(n => n.Discount >= 70 && n.Discount < 100).ToList();
                        ListItems.ItemsSource = Services;
                    }

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var item = button.DataContext as Service;

            NavigationService.Navigate(new EditPage(item));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var item = button.DataContext as Service; //получаем элемент
            Services.Remove(item);  //Удаляем элемент
            DBConnection.Connection.SaveChanges();
        }

        private void Recording_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new RecordingPage((Service)ListItemsAdmin.SelectedItem));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = Search.Text;

            if (IsAdmin) 
            {
                Services = DBConnection.Connection.Service.Where(n => n.Title.IndexOf(search) > 0 || n.Description.IndexOf(search) > 0).ToList();
                ListItemsAdmin.ItemsSource = Services;

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";

                if (search == "" || search == null)
                {
                    Services = DBConnection.Connection.Service.ToList();
                    ListItemsAdmin.ItemsSource = Services;

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
            }
            else if (!IsAdmin)
            {
                Services = DBConnection.Connection.Service.Where(n => n.Title.IndexOf(search) > 0 || n.Description.IndexOf(search) > 0).ToList();
                ListItems.ItemsSource = Services;

                NumberFrom.Text = $"{Services.Count}";
                NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";

                if (search == "" || search == null)
                {
                    Services = DBConnection.Connection.Service.ToList();
                    ListItems.ItemsSource = Services;

                    NumberFrom.Text = $"{Services.Count}";
                    NumberTo.Text = $"{DBConnection.Connection.Service.ToList().Count}";
                }
            }
        }
    }
}
