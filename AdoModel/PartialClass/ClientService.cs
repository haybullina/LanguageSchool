using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LearnLanguageSchool.AdoModel
{
    public partial class ClientService
    {
        public SolidColorBrush ColorForeground
        {
            get
            {
                if ((StartTime - DateTime.Now).TotalMinutes < 60)
                    return new SolidColorBrush(Colors.Red);
                return new SolidColorBrush(Colors.Black);

            }
        }
        public string Time 
        {
            get 
            {
                return $"{(StartTime - DateTime.Now).Hours} часов {(StartTime - DateTime.Now).Minutes} минут";
            }
        }

        public string Title 
        {
            get 
            {
                return DBConnection.Connection.Service.Where(n => n.ID == this.ServiceID).FirstOrDefault().Title;
            }
        }
        public string Email 
        {
            get 
            {
                return DBConnection.Connection.Client.Where(n => n.ID == this.ClientID).FirstOrDefault().Email;
            }
        }
        public string PhoneNumber 
        {
            get 
            {
                return DBConnection.Connection.Client.Where(n => n.ID == this.ClientID).FirstOrDefault().Phone;
            }
        }

        public string Name 
        {
            get 
            {
                var fname = DBConnection.Connection.Client.Where(n => n.ID == this.ClientID).FirstOrDefault().FirstName;
                var lname = DBConnection.Connection.Client.Where(n => n.ID == this.ClientID).FirstOrDefault().LastName;
                var patr = DBConnection.Connection.Client.Where(n => n.ID == this.ClientID).FirstOrDefault().Patronymic;

                return $"{lname} {fname} {patr}";
            }
        }
    }
}
