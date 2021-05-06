using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.PE1.Webshop.Domain
{
    public class Category 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
