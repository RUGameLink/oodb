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
            id = Guid.NewGuid().ToString();
        }

        public Service(string title, int price)
        {
            id = Guid.NewGuid().ToString();
            this.title = title;
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   id == service.id &&
                   title == service.title &&
                   price == service.price;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
