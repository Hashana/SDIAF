using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Account
{
    public partial class PaymentConf : System.Web.UI.Page
    {
        private int _orderId;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetOrderId();
        }

        protected void GetOrderId()
        {
            _orderId = Convert.ToInt32(Request.QueryString["order"]);
            lblOrderId.Text = "Your Order ID is: " + _orderId;
        }
    }
}