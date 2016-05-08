using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CoffeeShop.Account
{
    public partial class Cart : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");

        private string _name;
        private string _price;
        private string _todo;
        private string _qty;
        private List<string> cartItems = new List<string>();
     
        //public List<string> CartItems
        //{
        //    get { return cartItems; }
        //    set { cartItems = value; }
        //}

        
        protected void Page_Load(object sender, EventArgs e)
        {
           LoadCart();
            
        }

        private void LoadCart()
        {
            _name = Request.QueryString["name"];
            _price = Request.QueryString["price"];
            _todo = Request.QueryString["todo"];
            _qty = Request.QueryString["qty"];

            if (_todo == "add")
            {
                if (CartItems.CheckItemExists(_name, _price) == false)
                {
                    CartItems.AddItem(_name, _price);
                }
        
                
            }
            else if (_todo == "remove")
            {
                CartItems.RemoveItem(_name);
            }
            else if (_todo == "update")
            {
                CartItems.SetQuantity(_name, Convert.ToInt32(_qty));
            }
            
          
            if (CartItems.GetCount() != 0)
            {
                lblCart.Text = "<table  style='width:100%'><tr><th>Name</th><th>Strength</th><th>Grind</th><th>Origin</th><th>Price</th><th>Picture</th><th>Description</th><th>Available</th><th>Required</th><th>Remove?</th></tr>";

                lblCart.Text +=
                    "<tr style='display:none;'><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td><form><input type='submit'></form></td></tr>";

                foreach (var item in CartItems.Items)
                {
                    SqlCommand getItem = new SqlCommand("SELECT * FROM Coffee WHERE Name ='" + item.Name + "'", con);
                    con.Open();
                    SqlDataReader reader = getItem.ExecuteReader();
                    while (reader.Read())
                    {
                       lblCart.Text += "<tr><td>" + reader["Name"] + "</td><td>" + reader["Strength"] + "</td><td>" + reader["Grind"] + "</td><td>" + reader["Origin"] + "</td><td>" + reader["Price"] + "</td><td><img src ='/images/Coffee/" + reader["Name"] + ".jpg' height='60' width='60'</td><td>" + reader["Description"] + "</td><td class='maxqty'>" + reader["Qty"] + "</td><td><form action='Cart.aspx?name=" + reader["Name"] + "&price=" + reader["Price"] + "&todo=update&qty=" + CartItems.GetQuantity(reader["Name"].ToString()) + "' method='Post'><input type='number' max='" + reader["Qty"] + "' min='1' id='qtyBox" + reader["Name"] + "' value='" + CartItems.GetQuantity(reader["Name"].ToString()) + "' /></form></td><td><form action='Cart.aspx?name=" + reader["Name"] + "&price=" + reader["Price"] + "&todo=remove' method='Post'><input type='submit'  value ='Remove' style='width: 100 % '></form></td></tr>";
                    }
                    con.Close();
                    reader.Close();
                    

                }
                lblCart.Text += "</table>";
                lblSubTotal.Text = "<br/>Subtotal: £" + CartItems.GetCost()+ " <br/>Shipping Fee: £2.99 <br/><br/>Total Cost: £" + (CartItems.GetCost() + 2.99);
                lblProceedToPayment.Text = "<br/><br/><form action='Purchase.aspx?' method='Post'><input type='submit'  value ='Proceed To Payment' style='width: 100 % '></form>";
            }
            else
            {
                lblCart.Text = "<h2>You do not have any items in your cart.</h2>";
            }
        }

  }
}