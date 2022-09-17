using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb.Classes
{
    internal class Hall
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Зал")]
        public string title { get; set; }

        public Hall()
        {
            id = Guid.NewGuid().ToString();
        }

        public Hall(string title)
        {
            id = Guid.NewGuid().ToString();
            this.title = title;
        }
    }
}
