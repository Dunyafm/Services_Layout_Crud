using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.Models
{
    public class Product
    {
        
     
        internal readonly int id;
        internal int Id;

        public string Image { get; set; }
        public string Category { get; set; }
        public string Name { get; internal set; }
        public int Price { get; internal set; }
    }
}
