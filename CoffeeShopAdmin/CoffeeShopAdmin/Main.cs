using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAdmin
{
    public partial class Main : Form
    {
        private string selectedFilePath = "";
        private string targetPath = @"D:\Uni\SDIAF\Coffeeshop\Coffeeshop\Coffeeshop\images\Coffee\";
        private int editId;
        private Timer myUpdateTimer;
        private int _qty;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Uni\SDIAF\CoffeeShop\CoffeeShop\CoffeeShop\App_Data\aspnet-CoffeeShop-20160418102437.mdf;Initial Catalog=aspnet-CoffeeShop-20160418102437;Integrated Security=True");
        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetUpForm();
            UpdateGrid(dtgUpdateStock, "SELECT * From Coffee");
            SetUpUpdateTimer(); 
            AlertLowStock();
            PopulateOrders();
        }

        private void PopulateOrders()
        {
            //UpdateGrid(dtgOrders, "SELECT * FROM OrderLine");
            var dt = new DataTable();
            using (var da = new SqlDataAdapter("SELECT * FROM OrderLine", con))
            {
                da.Fill(dt);
            }
            dtgOrders.DataSource = dt.AsDataView();
            con.Close();
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
            txtQuickSearch.Text = "";
            pbCoffee.Image = null;
            btnUpdate.Enabled = false;
            btnCancelUpdate.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnClear.Enabled = true;
            btnQuickSearch.Enabled = true;
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
                System.IO.File.Copy(selectedFilePath, destFile, true);
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
                UpdateGrid(dtgUpdateStock, "SELECT * FROM Coffee"); 
                SetUpForm();
            }
          
        }
#endregion

        private void UpdateGrid(DataGridView grid, string query)
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(query, con))
            {
                da.Fill(dt);
            }
            grid.DataSource = dt.AsDataView();
            con.Close();

            //grid.AutoSize = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid.Columns[7].Visible = false;
            grid.ClearSelection();

        }

        #region Update Stock 

     

  

        #endregion

        #region Delete

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dtgUpdateStock.SelectedRows.Count == 1)
            {
                var response = MessageBox.Show("Delete?", "Are you sure you want to delete that entry?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    // One row selected for deletion
                    var selected = dtgUpdateStock.SelectedRows[0].Cells[0].Value;
                    SqlCommand deleteCoffee = new SqlCommand("DELETE FROM Coffee WHERE Id = " + selected, con);
                    con.Open();
                    deleteCoffee.ExecuteNonQuery();
                    con.Close();
                    File.Delete(targetPath + dtgUpdateStock.SelectedRows[0].Cells[1].Value + ".jpg");

                    MessageBox.Show("Entry has been removed!", "Deleted!", MessageBoxButtons.OK);
                    UpdateGrid(dtgUpdateStock, "SELECT * FROM Coffee");
                    pbUpdateCoffee.Image = null;

                }
            }
            else
            {
                MessageBox.Show("You must make a single selection entry to Delete!", " Delete?", MessageBoxButtons.OK);
            }
        }

        #endregion
        #region Edit


        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            //check if a row is selected
            if (dtgUpdateStock.SelectedRows.Count != 1)
            {
                // Multiple or no rows selected
                MessageBox.Show("Please make a single selection to edit!", "Select one row to edit",
                    MessageBoxButtons.OK);
            }
            else
            {
                // User has selected a single row - set up edit mode
                editId = Convert.ToInt32(dtgUpdateStock.SelectedRows[0].Cells[0].Value);
                _qty = Convert.ToInt32(dtgUpdateStock.SelectedRows[0].Cells[6].Value);
                txtCoffeeName.Text = dtgUpdateStock.SelectedRows[0].Cells[1].Value.ToString();
                cmbStrength.Text = dtgUpdateStock.SelectedRows[0].Cells[2].Value.ToString();
                cmbGrind.Text = dtgUpdateStock.SelectedRows[0].Cells[3].Value.ToString();
                txtOrigin.Text = dtgUpdateStock.SelectedRows[0].Cells[4].Value.ToString();
                txtPrice.Text = dtgUpdateStock.SelectedRows[0].Cells[5].Value.ToString();
                txtStockQty.Text = dtgUpdateStock.SelectedRows[0].Cells[6].Value.ToString();
                txtDescription.Text = dtgUpdateStock.SelectedRows[0].Cells[8].Value.ToString();
                btnUpdate.Enabled = true;
                btnCancelUpdate.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                pbCoffee.ImageLocation = targetPath + dtgUpdateStock.SelectedRows[0].Cells[1].Value + ".jpg";
                btnSearch.Enabled = false;
                btnClear.Enabled = false;
                btnQuickSearch.Enabled = false;
                _qty =Convert.ToInt32(dtgUpdateStock.SelectedRows[0].Cells[6].Value);

            }
        }

        private void dtgUpdateStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pbUpdateCoffee.ImageLocation = targetPath + dtgUpdateStock.SelectedRows[0].Cells[1].Value + ".jpg";
            pbUpdateCoffee.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            // Check user is sure
            var result = MessageBox.Show("Are you sure you wish to discard your changes?", "Exit editing this record?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // discard changes and display correct buttons
                SetUpForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(dtgUpdateStock,
                "SELECT * FROM Coffee WHERE Name Like '%" + txtCoffeeName.Text + "%' AND Strength Like '%" +
                cmbStrength.Text + "%' AND Grind Like '%" + cmbGrind.Text + "%' AND Origin Like '%" + txtOrigin.Text + "%' AND Price Like '%" + txtPrice.Text + "%'AND Qty Like '%" + txtStockQty.Text + "%'AND Description Like '%" + txtDescription.Text + "%'");
            
        }

        private void btnQuickSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid(dtgUpdateStock, "SELECT * FROM Coffee WHERE Name Like '%" + txtQuickSearch.Text + "%' Or Strength Like '%" + txtQuickSearch.Text + "%' Or Grind Like '%" + txtQuickSearch.Text + "%' Or Origin Like '%" + txtQuickSearch.Text + "%' Or Price Like '%" + txtQuickSearch.Text + "%' Or Qty Like '%" + txtQuickSearch.Text + "%' Or Description Like '%" + txtQuickSearch.Text + "%'");
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateGrid(dtgUpdateStock,"SELECT * FROM Coffee");
            SetUpForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check user is sure
            var result = MessageBox.Show("Are you sure you want to update this record? ", "Amend this record?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlCommand updateCoffee = new SqlCommand("UPDATE Coffee SET Name = '" + txtCoffeeName.Text + "', Strength = '" + cmbStrength.Text + "', Grind = '" + cmbGrind.Text + "', Origin = '" + txtOrigin.Text + "', Price = '" + txtPrice.Text + "', Qty = '" + txtStockQty.Text + "', Picture = '" + txtCoffeeName.Text + ".jpg', Description = '" + txtDescription.Text + "' WHERE Id = " + editId, con);
                con.Open();
                updateCoffee.ExecuteNonQuery();
                con.Close();
                

                // check if qty changed and was below stock level
                if (Convert.ToInt32(txtStockQty.Text) >= 1 && _qty < 10)
                {
                    CheckWhosWaiting(Convert.ToInt32(dtgUpdateStock.SelectedRows[0].Cells[0].Value));
                    UpdateWaitingList(Convert.ToInt32(dtgUpdateStock.SelectedRows[0].Cells[0].Value));
                }
                // updated changes so now display correct buttons
                UpdateGrid(dtgUpdateStock, "SELECT * FROM Coffee");
                
                SetUpForm();

            }
        }

        #endregion

        private void AlertLowStock()
        {
            SqlCommand checkQty = new SqlCommand("SELECT * FROM Coffee WHERE Qty <= 10", con);
            con.Open();
            var dataReader = checkQty.ExecuteReader();

            if (dataReader.HasRows)
            {
                con.Close();
                MessageBox.Show("Low Stock requires attention!", "Low Stock Levels", MessageBoxButtons.OK);
                UpdateGrid(dtgLowStock, "SELECT * FROM Coffee WHERE Qty <= 10");

            }
            else
            {
                con.Close();
            }
            dataReader.Close();
        }

        #region timer
        private void myUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateGrid(dtgUpdateStock, "SELECT * FROM Coffee");
            AlertLowStock();
            PopulateOrders();
        }

        private void SetUpUpdateTimer()
        {
            myUpdateTimer = new Timer();
            myUpdateTimer.Interval = (20 * 1000); // update every 20 seconds
            myUpdateTimer.Tick += myUpdateTimer_Tick;
            myUpdateTimer.Start();

         }

        #endregion

        private void dtgLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStockLevel.Text = dtgLowStock.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            SqlCommand updateStock = new SqlCommand("UPDATE Coffee SET Qty =" + txtStockLevel.Text +  "WHERE Id = " + dtgLowStock.SelectedRows[0].Cells[0].Value, con);
            con.Open();
            updateStock.ExecuteNonQuery();
            con.Close();
            CheckWhosWaiting(Convert.ToInt32(dtgLowStock.SelectedRows[0].Cells[0].Value.ToString()));
            UpdateGrid(dtgLowStock, "SELECT * FROM Coffee WHERE Qty <= 10");
            txtStockLevel.Clear();
            UpdateGrid(dtgUpdateStock, "SELECT * From Coffee");
        }

        private void CheckWhosWaiting(int itemId)
        {
            SqlCommand checkForReservations = new SqlCommand("SELECT * FROM WaitingForStock WHERE waitingFor = " + itemId + "AND emailSent = 0", con);
            con.Open();
            var dataReader = checkForReservations.ExecuteReader();
            List<string> emails = new List<string>();
            while (dataReader.Read())
            {
                var email = dataReader.GetValue(1);
                emails.Add(email.ToString());

            }
            con.Close();
            dataReader.Close();
            SendEmails(emails);
            // update db so future emails are not sent
            UpdateWaitingList(itemId);

        }

        private void SendEmails(List<string> emails)
        {
            foreach (var email in emails)
            {
                // create mail and network credentials objects
                MailMessage newMail = new MailMessage();
                NetworkCredential credentials = new NetworkCredential("SDIAF1516@gmail.com", "UCPsdiaf1516");

                // set up email
                // Set up email details.
                newMail.To.Add(email);
                newMail.Subject = "The product you requested is back in stock!";
                newMail.Body = "Hello valued customer,<br/><br/>Thank you for your patience whilst we sourced some more of your favourite coffee! <br/><br/>I am pleased to confirm that your requested coffee is now back in stock! <br/>Thank you for continuing to choose CoffeeCo! (SID:1340531/1)";
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
            MessageBox.Show("Your emails have been sent", "Emails Sent", MessageBoxButtons.OK);
        }

        private void UpdateWaitingList(int productId)
        {
            SqlCommand updateWaitingList = new SqlCommand("UPDATE WaitingForStock SET emailSent = 1 WHERE waitingFor =" + productId, con);
            con.Open();
            updateWaitingList.ExecuteNonQuery();
            con.Close();

        }
    }

}

