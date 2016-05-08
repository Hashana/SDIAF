using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Coffee : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");

        private string _grindSelected = "";
        private string _strengthSelected = "";
        private string _originSelected = "";
        public bool originsSet = false;
        private int originListCount;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCoffee("SELECT * FROM Coffee");
            if (originsSet == false)
            {
                PopulateOrigins();
            }
                
        }

        private void LoadCoffee(string sql)
        {
            // Create query command based on string arguement
            SqlCommand queryData = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = queryData.ExecuteReader();

            // check if user is logged in
            if (User.Identity.Name != "")
            {

                lblCoffee.Text = "<table style='width:100%;'><thead><tr><th>Name</th><th>Strength</th><th>Grind</th><th>Origin</th><th>Price</th><th>Picture</th><th>Description</th><th>Available</th><th>Buy</th></tr></thead><tbody>";

                lblCoffee.Text += "<tr style='display: none;'><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td><form action='Account/Cart.aspx' method='Post'><input type='submit'></form></td></tr>";
                while (reader.Read())
                {
                    lblCoffee.Text += "<tr><td>" + reader["Name"] + "</td><td>" + reader["Strength"] + "</td><td>" + reader["Grind"] + "</td><td>" + reader["Origin"] + "</td><td>" + reader["Price"] + "</td><td><img src='/images/Coffee/" + reader["Name"] + ".jpg' height='60' width='60'></td><td>" + reader["Description"] + "</td><td>" + reader["Qty"] + "</td><td><form action='Account/Cart.aspx?name=" + reader["Name"] + "&price=" + reader["Price"] + "&todo=add' method='Post'><input type='submit' value='Add To Cart' style='width: 100%;' /></form></td></tr>";

                    

                }
                lblCoffee.Text += "</tbody></table>";


            }

            else

            {

                lblCoffee.Text = "<table  style='width:100%'><tr><th>Name</th><th>Strength</th><th>Grind</th><th>Origin</th><th>Price</th><th>Picture</th><th>Description</th></tr><br/>";
                while (reader.Read())
                {
                    lblCoffee.Text += "<tr><td>" + reader["Name"] + "</td><td>" + reader["Strength"] + "</td><td>" + reader["Grind"] + "</td><td>" + reader["Origin"] + "</td><td>" + reader["Price"] + "</td><td><img src ='/images/Coffee/" + reader["Name"] + ".jpg' height='60' width='60'</td><td>" + reader["Description"] + "</td></tr><br/>";
                }
                lblCoffee.Text += "</table>";

            }
            
           
            reader.Close();
            con.Close();
        }

        protected void btnQSearch_Click(object sender, EventArgs e)
        {
            LoadCoffee("SELECT * FROM Coffee WHERE Name Like '%" + txtQSearch.Text + "%' Or Strength Like '%" + txtQSearch.Text + "%' Or Grind Like '%" + txtQSearch.Text + "%' Or Origin Like '%" + txtQSearch.Text + "%' Or Price Like '%" + txtQSearch.Text + "%' Or Qty Like '%" + txtQSearch.Text + "%' Or Description Like '%" + txtQSearch.Text + "%'");
        }

        protected void btnClearResults_Click(object sender, EventArgs e)
        {
            LoadCoffee("SELECT * FROM Coffee");
            txtQSearch.Text = "";
            ddlGrind.SelectedIndex = 0;
            ddlStrength.SelectedIndex = 0;
            ddlOrigin.SelectedValue = "";
        }

        protected void PopulateOrigins()
        {
            if (ddlOrigin.Items.Count == 0)
            {
               SqlCommand getOrigins = new SqlCommand("SELECT DISTINCT Origin FROM Coffee", con);
                SqlDataReader reader;

                try
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = "";
                    newItem.Value = "";
                    ddlOrigin.Items.Add(newItem);
                    con.Open();
                    reader = getOrigins.ExecuteReader();
                    while (reader.Read())
                    {
                        newItem = new ListItem();
                        newItem.Text = reader["Origin"].ToString();
                        newItem.Value = reader["Origin"].ToString();
                        ddlOrigin.Items.Add(newItem);
                    }
                    reader.Close();
                    con.Close();
                    originsSet = true;


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.StackTrace);
                }
            }
           
        }

            

        protected void ddlGrind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlGrind.SelectedIndex == 0)
            {
                _grindSelected = "";
            }
            else
            {
                _grindSelected = ddlGrind.SelectedValue.ToString();
            }
           
            CheckSelectedValues();
            
        }

        private void CheckSelectedValues()
        {
            bool checkStrength = _strengthSelected != "";
            bool checkOrigin = _originSelected != "";
            bool checkGrind = _grindSelected != "";

            if (checkStrength && checkOrigin && checkGrind)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Grind ='" + _grindSelected + "' AND Origin ='"+_originSelected + "' AND Strength = '" + _strengthSelected +"'");
            }
            else if (checkStrength && checkOrigin)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Origin ='" + _originSelected + "' AND Strength = '" + _strengthSelected + "'");
            }
            else if (checkStrength && checkGrind)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Grind ='" + _grindSelected + "' AND Strength = '" + _strengthSelected + "'");
            }
            else if (checkGrind && checkOrigin)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Grind ='" + _grindSelected + "' AND Origin ='" + _originSelected + "'");
            }
            else if (checkGrind )
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Grind ='" + _grindSelected + "'");
            }
            else if (checkOrigin)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Origin ='" + _originSelected + "'");
            }
            else if (checkStrength)
            {
                LoadCoffee("SELECT * FROM Coffee WHERE Strength = '" + _strengthSelected + "'");
            }
            else
            {
                LoadCoffee("Select * FROM Coffee");
            }
        }

        protected void ddlStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlStrength.SelectedIndex == 0)
            {
                _strengthSelected = "";
            }
            else
            {
                _strengthSelected = ddlStrength.SelectedValue;
            }
            
            CheckSelectedValues();
        }

        protected void ddlOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOrigin.SelectedIndex == 0)
            {
                _originSelected = "";
            }
            else
            {
                _originSelected = ddlOrigin.SelectedValue;
            }

            CheckSelectedValues();
        }
    }
}