namespace CoffeeShopAdmin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbCoffee = new System.Windows.Forms.PictureBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbStrength = new System.Windows.Forms.ComboBox();
            this.cmbGrind = new System.Windows.Forms.ComboBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgUpdateStock = new System.Windows.Forms.DataGridView();
            this.pbUpdateCoffee = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).BeginInit();
            this.tpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUpdateStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMain);
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.Tan;
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(855, 351);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.Color.Tan;
            this.tpAdd.Controls.Add(this.label7);
            this.tpAdd.Controls.Add(this.txtDescription);
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.pbCoffee);
            this.tpAdd.Controls.Add(this.txtFilePath);
            this.tpAdd.Controls.Add(this.btnSelectImage);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.label5);
            this.tpAdd.Controls.Add(this.label4);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Controls.Add(this.txtStockQty);
            this.tpAdd.Controls.Add(this.txtPrice);
            this.tpAdd.Controls.Add(this.cmbStrength);
            this.tpAdd.Controls.Add(this.cmbGrind);
            this.tpAdd.Controls.Add(this.txtOrigin);
            this.tpAdd.Controls.Add(this.txtCoffeeName);
            this.tpAdd.Location = new System.Drawing.Point(4, 22);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(855, 351);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "Add Coffee";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Coffee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbCoffee
            // 
            this.pbCoffee.Location = new System.Drawing.Point(17, 221);
            this.pbCoffee.Name = "pbCoffee";
            this.pbCoffee.Size = new System.Drawing.Size(159, 123);
            this.pbCoffee.TabIndex = 22;
            this.pbCoffee.TabStop = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(28, 191);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtFilePath.TabIndex = 21;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(26, 162);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(100, 23);
            this.btnSelectImage.TabIndex = 20;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity in Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Grind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coffee Name";
            // 
            // txtStockQty
            // 
            this.txtStockQty.Location = new System.Drawing.Point(158, 127);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(178, 20);
            this.txtStockQty.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(26, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // cmbStrength
            // 
            this.cmbStrength.FormattingEnabled = true;
            this.cmbStrength.Items.AddRange(new object[] {
            "Light to Medium Roast",
            "Medium Roast",
            "Medium to Dark Roast",
            "Dark Roast",
            "Very Dark Roast"});
            this.cmbStrength.Location = new System.Drawing.Point(158, 48);
            this.cmbStrength.Name = "cmbStrength";
            this.cmbStrength.Size = new System.Drawing.Size(178, 21);
            this.cmbStrength.TabIndex = 11;
            // 
            // cmbGrind
            // 
            this.cmbGrind.FormattingEnabled = true;
            this.cmbGrind.Items.AddRange(new object[] {
            "Extra Coarse Grind",
            "Coarse Grind",
            "Medium Grind",
            "Fine Grind",
            "Extra Fine Grind"});
            this.cmbGrind.Location = new System.Drawing.Point(28, 87);
            this.cmbGrind.Name = "cmbGrind";
            this.cmbGrind.Size = new System.Drawing.Size(121, 21);
            this.cmbGrind.TabIndex = 10;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(158, 88);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(100, 20);
            this.txtOrigin.TabIndex = 9;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(28, 49);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(121, 20);
            this.txtCoffeeName.TabIndex = 8;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.Tan;
            this.tpUpdate.Controls.Add(this.pbUpdateCoffee);
            this.tpUpdate.Controls.Add(this.dtgUpdateStock);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(855, 351);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "Update Stock";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(182, 174);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(154, 75);
            this.txtDescription.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // dtgUpdateStock
            // 
            this.dtgUpdateStock.AllowUserToAddRows = false;
            this.dtgUpdateStock.AllowUserToDeleteRows = false;
            this.dtgUpdateStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUpdateStock.Location = new System.Drawing.Point(22, 25);
            this.dtgUpdateStock.MultiSelect = false;
            this.dtgUpdateStock.Name = "dtgUpdateStock";
            this.dtgUpdateStock.ReadOnly = true;
            this.dtgUpdateStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUpdateStock.Size = new System.Drawing.Size(824, 226);
            this.dtgUpdateStock.TabIndex = 0;
            this.dtgUpdateStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUpdateStock_CellContentClick);
            // 
            // pbUpdateCoffee
            // 
            this.pbUpdateCoffee.Location = new System.Drawing.Point(22, 258);
            this.pbUpdateCoffee.Name = "pbUpdateCoffee";
            this.pbUpdateCoffee.Size = new System.Drawing.Size(194, 86);
            this.pbUpdateCoffee.TabIndex = 1;
            this.pbUpdateCoffee.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(863, 378);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).EndInit();
            this.tpUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUpdateStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCoffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbStrength;
        private System.Windows.Forms.ComboBox cmbGrind;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbCoffee;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dtgUpdateStock;
        private System.Windows.Forms.PictureBox pbUpdateCoffee;
    }
}