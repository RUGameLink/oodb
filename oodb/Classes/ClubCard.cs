using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class ClubCard
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Клиент")]
        public Client client { get; set; }

        [DisplayName("Услуга")]
        public Service service { get; set; }

        [DisplayName("Старт карты")]
        public DateTime startCard { get; set; }

        [DisplayName("Конец карты")]
        public DateTime endCard { get; set; }

        [DisplayName("Цена абонемента")]
        public int price { get; set; }

        public ClubCard()
        {
            id = Guid.NewGuid().ToString();
        }

        public ClubCard(Client client, Service service, DateTime startCard, DateTime endCard, int price)
        {
            id = Guid.NewGuid().ToString();
            this.client = client;
            this.service = service;
            this.startCard = startCard;
            this.endCard = endCard;
            this.price = price;
        }
    }
}
