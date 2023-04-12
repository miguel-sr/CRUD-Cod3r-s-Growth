using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Models
{
    public class Part
    {
        public Part(string id, string category, string name, string description, int inventory) 
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.description = description;
            this.inventory = inventory;
        }

        public string id { get; set; }

        public string category { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int inventory { get; set; }
    }
}
