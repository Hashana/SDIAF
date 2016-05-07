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
          // MessageBox.Show(_name, _name, MessageBoxButtons.OK);
           //     cartItems.Add(_name);
            CartItems.AddItem(_name);
          
            if (CartItems.GetCount() != 0)
            {
                lblCart.Text = "<table  style='width:100%'><tr><th>Name</th><th>Strength</th><th>Grind</th><th>Origin</th><th>Price</th><th>Picture</th><th>Description</th><th>Stock Available</th><th>Quantity</th><th>Remove Item?</th></tr><br/>";
                foreach (var item in CartItems.Items)
                {
                    SqlCommand getItem = new SqlCommand("SELECT * FROM Coffee WHERE Name ='" + item + "'", con);
                    con.Open();
                    SqlDataReader reader = getItem.ExecuteReader();
                    while (reader.Read())
                    {
                       lblCart.Text += "<tr><td>" + reader["Name"] + "</td><td>" + reader["Strength"] + "</td><td>" + reader["Grind"] + "</td><td>" + reader["Origin"] + "</td><td>" + reader["Price"] + "</td><td><img src ='/images/Coffee/" + reader["Name"] + ".jpg' height='60' width='60'</td><td>" + reader["Description"] + "</td><td>" + reader["Qty"] + "</td><td><input type='text'/</td><td><form action ='Account/Cart.aspx?name=" + reader["Name"] + "' method='Post'><input type=submit  value ='Remove' style='width: 100 % '></form></tr><br/>";

                    }
                    con.Close();
                    reader.Close();
                    
                }
                lblCart.Text += "</table>";
            }
            else
            {
                lblCart.Text = "<h2>You do not have any items in your cart.</h2>";
            }
        }

        protected void RemoveCartItem(string item)
        {
            CartItems.RemoveItem(item);
        }
    }
}