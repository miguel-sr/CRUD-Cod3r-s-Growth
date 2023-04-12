using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Models
{
    public class Category
    {

        public Category(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string id { get; set; }

        public string name { get; set; }
    }
}
