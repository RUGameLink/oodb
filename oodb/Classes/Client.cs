using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class Client
    {
        [DisplayName("id")]
        public string id { get; set; }
        
        [DisplayName("Адрес клиента")]
        public string adress { get; set; }

        [DisplayName("Телефон клиента")]
        public string phone { get; set; }

        [DisplayName("Имя клиента")]
        public string name { get; set; }

        [DisplayName("Фамилия клиента")]
        public string surname { get; set; }

        [DisplayName("Отчество клиента")]
        public string patronymic { get; set; }

        public Client()
        {

        }

        public Client(string adress, string phone, string name, string surname, string patronymic)
        {
            this.adress = adress;
            this.phone = phone;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
    }
}
