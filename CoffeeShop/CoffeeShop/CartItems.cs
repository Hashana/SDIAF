using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop
{
    public class CartItems
    {
        public static List<Item> Items { get; private set; }

        public static readonly CartItems Instance;

        static CartItems()
        {
            // If the cart is not in the session, create one and put it there
            // Otherwise, get it from the session
            if (HttpContext.Current.Session["ShoppingCart"] == null)
            {
                Instance = new CartItems();
                CartItems.Items = new List<Item>();
                HttpContext.Current.Session["ShoppingCart"] = Instance;
            }
            else
            {
                Instance = (CartItems)HttpContext.Current.Session["ShoppingCart"];
            }
        }

        public static void AddItem(string name,string price)
        {
            Items.Add(new Item(name, price));
        }

        public static void RemoveItem(string name)
        {
            var item = Items.First(x => x.Name == name);
            Items.Remove(item);
        }

        public static int GetCount()
        {
            return Items.Count;
        }

        public static bool CheckItemExists(string name, string price)
        {
            if (Items.Contains(new Item(name, price)))
            {
                return true;
            }
            return false;
        }

        public static double GetCost()
        {
            double cost = 0.0;
            foreach (var item in Items)
            {
                var itemCost = Convert.ToDouble(item.Price) * item.Quantity;
                cost += itemCost;
            }
            
            return cost;
        }

        public static int GetQuantity(string name)
        {
            var item = Items.First(x => x.Name == name);
            return item.Quantity;
        }

        public static void SetQuantity(string name, int quantity)
        {
            var item = Items.First(x => x.Name == name);
            item.Quantity = quantity;
        }
    }
}