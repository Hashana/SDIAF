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
    public partial class Main : Form
    {
        private string selectedFilePath = "";
        private string targetPath = @"D:\Uni\SDIAF\Coffeeshop\images\";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");
        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetUpForm();
            UpdateGrid(dtgUpdateStock, "SELECT * From Coffee");
        }

        private void SetUpForm()
        {
            txtOrigin.Text = "";
            txtCoffeeName.Text = "";
            txtFilePath.Text = "";
            txtPrice.Text = "";
            txtStockQty.Text = "";
            txtDescription.Text = "";
            cmbStrength.Text = "";
            cmbGrind.Text = "";
            pbCoffee.Image = null;
        }

        #region AddCoffee Methods

        private void GetImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFilePath = dialog.FileName;
                pbCoffee.ImageLocation = selectedFilePath;
                pbCoffee.SizeMode = PictureBoxSizeMode.CenterImage;
                txtFilePath.Text = selectedFilePath;

                MoveImage(selectedFilePath);
            }
        }

        private void MoveImage(string selectedFilePath)
        {
            string fileName = txtCoffeeName.Text + ".jpg";
            string sourcePath = @selectedFilePath;
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            //string targetPath = @"D:\Uni\SDIAF\Coffeeshop\images";

            try
            {
                System.IO.File.Copy(selectedFilePath, destFile);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error", e.StackTrace, MessageBoxButtons.OK);
            }
           
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            GetImage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if textboxes are populated
            if (txtCoffeeName.Text == "" || txtOrigin.Text == "" || txtPrice.Text == "" || txtStockQty.Text == "" ||
                txtFilePath.Text == "" || txtDescription.Text == "")
            {
                // inform user empty textbox
                MessageBox.Show("You need to complete all fields before adding the Coffee", "Complete empty fields!", MessageBoxButtons.OK);
            }
            else
            {
                // add record
                SqlCommand addCoffee = new SqlCommand("INSERT INTO Coffee VALUES('" + txtCoffeeName.Text + "', '" + cmbStrength.Text + "', '" + cmbGrind.Text + "', '" + txtOrigin.Text + "', '" + txtPrice.Text + "', '" + txtStockQty.Text + "', '"+ txtCoffeeName.Text +".jpg', '"+ txtDescription.Text +"')", con);

                con.Open();
                addCoffee.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Coffee Added", "Entry Added!", MessageBoxButtons.OK);
                //update dtg
                SetUpForm();
            }
          
        }
#endregion

        private void UpdateGrid(DataGridView grid, string query)
        {
           // SqlCommand getData = new SqlCommand(query,con);
            //con.Open();
         //   var dataReader = getData.ExecuteReader();

            var dt = new DataTable();
            using (var da = new SqlDataAdapter(query, con))
            {
                da.Fill(dt);
            }
            grid.DataSource = dt.AsDataView();
            con.Close();

            grid.AutoSize = true;
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           


        }

        #region Update Stock 

     

        private void dtgUpdateStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pbUpdateCoffee.ImageLocation = targetPath + dtgUpdateStock.SelectedRows[0].Cells[1].Value + ".jpg";
            pbUpdateCoffee.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        #endregion
    }

}
