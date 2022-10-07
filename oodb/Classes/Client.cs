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
            id = Guid.NewGuid().ToString();
        }

        public Client(string adress, string phone, string name, string surname, string patronymic)
        {
            id = Guid.NewGuid().ToString();
            this.adress = adress;
            this.phone = phone;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   id == client.id &&
                   adress == client.adress &&
                   phone == client.phone &&
                   name == client.name &&
                   surname == client.surname &&
                   patronymic == client.patronymic;
        }

        public override string ToString()
        {
            return surname;
        }
    }
}
