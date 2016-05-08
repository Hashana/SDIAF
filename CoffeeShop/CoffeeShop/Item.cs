using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop
{
    public class Item
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }

        public Item(string name, string price)
        {
            Name = name;
            Price = price;
            Quantity = 1;
        }

        
    }
}