using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAdmin
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand checkLogin = new SqlCommand("SELECT * FROM AdminUsers WHERE UserName ='" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';", con);
            con.Open();
            var dataReader = checkLogin.ExecuteReader();
          
            if (dataReader.HasRows)
            {
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Fail", "Not Logged in!", MessageBoxButtons.OK);
            }
            dataReader.Close();
            con.Close();
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
