using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class TaskTable
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Сотрудник")]
        public Staff staff { get; set; }

        [DisplayName("Зал")]
        public Hall hall { get; set; }

        [DisplayName("Клиент")]
        public Client client { get; set; }

        [DisplayName("Дата занятия")]
        public string dateLesson { get; set; }

        [DisplayName("Продолжительность занятия")]
        public int duration { get; set; }

        public TaskTable()
        {
            id = Guid.NewGuid().ToString();
        }

        public TaskTable(Staff staff, Hall hall, Client client, string dateLesson, int duration)
        {
            id = Guid.NewGuid().ToString();
            this.staff = staff;
            this.hall = hall;
            this.client = client;
            this.dateLesson = dateLesson;
            this.duration = duration;
        }
    }
}
