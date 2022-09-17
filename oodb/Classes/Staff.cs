using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class Staff
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Адрес сотрудника")]
        public string adress { get; set; }
        
        [DisplayName("Телефон сотрудника")]
        public string phone { get; set; }

        [DisplayName("Имя сотрудника")]
        public string name { get; set; }

        [DisplayName("Фамилия сотрудника")]
        public string surname { get; set; }

        [DisplayName("Отчество сотрудника")]
        public string patronymic { get; set; }

        public Staff()
        {

        }

        public Staff(string adress, string phone, string name, string surname, string patronymic)
        {
            this.adress = adress;
            this.phone = phone;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
    }
}
