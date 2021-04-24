using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public byte[] Photo { get; set; }
        public int Quantity { get; set; }
    }
}
