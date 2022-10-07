using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class Search
    {
        [DisplayName ("Сотрудник")]
        public Staff Staff { get; set; }
        [DisplayName("Число клиентов")]
        public int Count { get; set; }


        public Search(int count, Staff staff)
        {
            Count = count;
            Staff = staff;
        }
    }
}
