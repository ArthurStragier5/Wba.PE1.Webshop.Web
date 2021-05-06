using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.PE1.Webshop.Domain
{
    public  class Product
    {

        public long Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Info { get; set; }
        public string Storage { get; set; }
        public string Size { get; set; }
        public int? SortNumber { get; set; }
        public Category Category { get; set; }
    }
}
