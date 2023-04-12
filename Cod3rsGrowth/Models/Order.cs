using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Models
{
    public class Order
    {
        public Order(string id, string client_name, string client_id, string client_mail, DateTime delivery_date) 
        { 
            this.id = id;
            this.client_name = client_name;
            this.client_id = client_id;
            this.client_mail = client_mail;
            this.delivery_date = delivery_date;
        }
            
        public string id { get; set; }

        public string client_name { get; set; }

        public string client_id { get; set; }

        public string client_mail { get; set; }

        // TODO: Field for parts list

        public DateTime delivery_date { get; set; }

    }

}
