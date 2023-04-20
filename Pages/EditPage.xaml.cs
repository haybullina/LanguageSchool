using LearnLanguageSchool.AdoModel;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Service service;
        public EditPage(Service service)
        {
            InitializeComponent();

            this.service = service;
            TbxName.Text = service.Title;
            TbxCost.Text = ((int)service.Cost).ToString();
            TbxDiscount.Text = ((int)service.Discount).ToString();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                service.Title = TbxName.Text;
                service.Cost = Convert.ToDecimal(TbxCost.Text);
                service.Discount = Convert.ToDouble(TbxDiscount.Text);
                DBConnection.Connection.SaveChanges();
                MessageBox.Show("Сохранено!");
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
