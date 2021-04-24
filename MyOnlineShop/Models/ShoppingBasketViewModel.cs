using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class ShoppingBasketViewModel
    {
        public ShoppingBasketViewModel()
        {

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        
    }
}
