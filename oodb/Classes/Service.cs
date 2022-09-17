using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class Service
    {
        [DisplayName("id")]
        public string id { get; set; }  
        [DisplayName("Название услуги")]
        public string title { get; set; }

        [DisplayName("Цена")]
        public int price { get; set; }

        public Service()
        {

        }

        public Service(string title, int price)
        {
            this.title = title;
            this.price = price;
        }
    }
}
