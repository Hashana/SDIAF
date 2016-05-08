using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Google.Maps.Geocoding;

namespace CoffeeShop.Account
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            GetPaymentAmount();
        }

        protected void btnFindBillingAddress_Click(object sender, EventArgs e)
        {
            // Find address
            var request = new GeocodingRequest();
            request.Address = txtBillingPostcode.Text;
            // not sure what this is but it needs to be false
            request.Sensor = false;
            var response = new GeocodingService().GetResponse(request);
            var result = response.Results.First();
            lblBillingAddress.Text = "Billing Address: " + "<br/><br/>" + txtBillingHouseNum.Text + " " + result.AddressComponents.ElementAt(1).LongName + "<br/>" + result.AddressComponents.ElementAt(2).LongName + "<br/>" + result.AddressComponents.ElementAt(3).LongName + "<br/>" + result.AddressComponents.ElementAt(4).LongName + "<br/>" + result.AddressComponents.ElementAt(0).LongName + "<br/>" + result.AddressComponents.ElementAt(5).ShortName;
        }

        protected void GetPaymentAmount()
        {
            lblAmount.Text = "Total Cost: £" + (CartItems.GetCost() + 2.99); 
        }

        protected void txtPlaceOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in CartItems.Items)
            {
                try
                {
                    // reduce stock from coffee table
                    SqlCommand reduceStock =
                        new SqlCommand(
                            "UPDATE Coffee SET Qty = Qty-" + Convert.ToInt32(item.Quantity) + " WHERE Name ='" + item.Name + "'", con);
                    con.Open();
                    reduceStock.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                
            }
            // insert order to db 
            SqlCommand createOrder = new SqlCommand("INSERT INTO Orders VALUES('"+ txtEmailPurchase.Text + "') SELECT SCOPE_IDENTITY()", con);
            con.Open();
            var newId = createOrder.ExecuteScalar();
            con.Close();
            
            // Create Order lines
            foreach (var item in CartItems.Items)
            {
                SqlCommand createOrderLines = new SqlCommand("INSERT INTO OrderLine VALUES("+ newId + ", '"+item.Name +"', "+Convert.ToInt32(item.Quantity) +")", con);
                con.Open();
                createOrderLines.ExecuteNonQuery();
                con.Close();
            }

            //send email
            SendConfirmationEmail(txtEmailPurchase.Text);

            // clear cart
            CartItems.Items.Clear();

            // Redirect to Pyment Confirmation Page
            Response.Redirect("PaymentConf.aspx?order="+newId);

        }

        protected void SendConfirmationEmail(string email)
        {
            // create mail and network credentials objects
            MailMessage newMail = new MailMessage();
            NetworkCredential credentials = new NetworkCredential("SDIAF1516@gmail.com", "UCPsdiaf1516");

            // set up email
            // Set up email details.
            newMail.To.Add(email);
            newMail.Subject = "Thank you for your order!";
            newMail.Body = "Hello valued customer,<br/><br/>Thank you for your purchase. <br/><br/>I am pleased to confirm that your order for coffee is being processed and will be with you within 5 working days!<br/><br/>Thank you for continuing to choose CoffeeCo!";
            newMail.From = new MailAddress("SDIAF1516@gmail.com");
            newMail.IsBodyHtml = true;

            // Connect to server to be sent from
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credentials;
            smtp.EnableSsl = true;
            smtp.Port = 587;

            // Send email
            smtp.Send(newMail);
        }
    }
}