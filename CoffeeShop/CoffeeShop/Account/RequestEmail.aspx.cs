using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CoffeeShop.Account
{
    public partial class RequestEmail : System.Web.UI.Page
    {
        private int productId;
        private string productName;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            productId = Convert.ToInt32(Request.QueryString["product"]);
            productName = Request.QueryString["productName"];
           
        }

        protected void btnEmailRequest_Click(object sender, EventArgs e)
        {
            SqlCommand requestNotification = new SqlCommand("INSERT INTO WaitingForStock VALUES('"+txtLowStockEmailRequest.Text + "', 0, "+productId +")", con);
            con.Open();
            requestNotification.ExecuteNonQuery();
            con.Close();
            CartItems.RemoveItem(productName);
            Response.Redirect("Requested.aspx?");
        }
    }
}