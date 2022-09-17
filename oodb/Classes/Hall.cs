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
                
        }

        public Hall(string title)
        {
            this.title = title;
        }
    }
}
