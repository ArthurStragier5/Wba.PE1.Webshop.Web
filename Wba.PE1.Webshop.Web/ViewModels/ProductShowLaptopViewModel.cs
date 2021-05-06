using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.PE1.Webshop.Domain;

namespace Wba.PE1.Webshop.Web.ViewModels
{
    public class ProductShowLaptopViewModel
    {
        public long? Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Info { get; set; }
        public string Storage { get; set; }
        public string Size { get; set; }
        //public Brand Brand { get; set; }
        //public Color Color { get; set; }
        public bool BackButton { get; set; }
    }
}

