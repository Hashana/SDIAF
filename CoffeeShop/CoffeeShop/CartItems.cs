using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop
{
    public class CartItems
    {
        public static List<string> Items { get; private set; }

        public static readonly CartItems Instance;

        static CartItems()
        {
            // If the cart is not in the session, create one and put it there
            // Otherwise, get it from the session
            if (HttpContext.Current.Session["ShoppingCart"] == null)
            {
                Instance = new CartItems();
                CartItems.Items = new List<string>();
                HttpContext.Current.Session["ShoppingCart"] = Instance;
            }
            else
            {
                Instance = (CartItems)HttpContext.Current.Session["ShoppingCart"];
            }
        }

        public static void AddItem(string name)
        {
            Items.Add(name);
        }

        public static void RemoveItem(string name)
        {
            Items.Remove(name);
        }

        public static int GetCount()
        {
            return Items.Count;
        }

    }
}