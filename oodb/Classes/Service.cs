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

        
        private string _title;

        [DisplayName("Название услуги")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private int _price;
        [DisplayName("Цена")]
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public Service()
        {
            id = Guid.NewGuid().ToString();
        }

        public Service(string title, int price)
        {
            id = Guid.NewGuid().ToString();
            this._title = title;
            this._price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   id == service.id &&
                   _title == service.Title &&
                   _price == service._price;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
