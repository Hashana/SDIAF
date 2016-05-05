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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuickSearch = new System.Windows.Forms.Button();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.pbUpdateCoffee = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgUpdateStock = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
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
            this.tpLowStock = new System.Windows.Forms.TabPage();
            this.dtgLowStock = new System.Windows.Forms.DataGridView();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUpdateStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).BeginInit();
            this.tpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMain);
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpLowStock);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.Tan;
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(806, 425);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.Color.Tan;
            this.tpAdd.Controls.Add(this.btnClear);
            this.tpAdd.Controls.Add(this.btnQuickSearch);
            this.tpAdd.Controls.Add(this.txtQuickSearch);
            this.tpAdd.Controls.Add(this.btnSearch);
            this.tpAdd.Controls.Add(this.btnCancelUpdate);
            this.tpAdd.Controls.Add(this.pbUpdateCoffee);
            this.tpAdd.Controls.Add(this.btnUpdate);
            this.tpAdd.Controls.Add(this.btnEdit);
            this.tpAdd.Controls.Add(this.btnDelete);
            this.tpAdd.Controls.Add(this.dtgUpdateStock);
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
            this.tpAdd.Size = new System.Drawing.Size(806, 425);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "Add Coffee";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(319, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear Results";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuickSearch
            // 
            this.btnQuickSearch.Location = new System.Drawing.Point(319, 292);
            this.btnQuickSearch.Name = "btnQuickSearch";
            this.btnQuickSearch.Size = new System.Drawing.Size(75, 23);
            this.btnQuickSearch.TabIndex = 34;
            this.btnQuickSearch.Text = "Quicksearch";
            this.btnQuickSearch.UseVisualStyleBackColor = true;
            this.btnQuickSearch.Click += new System.EventHandler(this.btnQuickSearch_Click);
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(213, 294);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(100, 20);
            this.txtQuickSearch.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(213, 394);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnCancelUpdate.TabIndex = 31;
            this.btnCancelUpdate.Text = "Cancel Changes";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // pbUpdateCoffee
            // 
            this.pbUpdateCoffee.Location = new System.Drawing.Point(639, 294);
            this.pbUpdateCoffee.Name = "pbUpdateCoffee";
            this.pbUpdateCoffee.Size = new System.Drawing.Size(159, 123);
            this.pbUpdateCoffee.TabIndex = 30;
            this.pbUpdateCoffee.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Apply Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(175, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit Coffee";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Coffee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dtgUpdateStock
            // 
            this.dtgUpdateStock.AllowUserToAddRows = false;
            this.dtgUpdateStock.AllowUserToDeleteRows = false;
            this.dtgUpdateStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUpdateStock.Location = new System.Drawing.Point(175, 62);
            this.dtgUpdateStock.MultiSelect = false;
            this.dtgUpdateStock.Name = "dtgUpdateStock";
            this.dtgUpdateStock.ReadOnly = true;
            this.dtgUpdateStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUpdateStock.Size = new System.Drawing.Size(628, 226);
            this.dtgUpdateStock.TabIndex = 26;
            this.dtgUpdateStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUpdateStock_CellContentClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(154, 75);
            this.txtDescription.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Coffee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbCoffee
            // 
            this.pbCoffee.Location = new System.Drawing.Point(10, 217);
            this.pbCoffee.Name = "pbCoffee";
            this.pbCoffee.Size = new System.Drawing.Size(159, 123);
            this.pbCoffee.TabIndex = 22;
            this.pbCoffee.TabStop = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(21, 187);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtFilePath.TabIndex = 21;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(19, 158);
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
            this.label6.Location = new System.Drawing.Point(696, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity in Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Grind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coffee Name";
            // 
            // txtStockQty
            // 
            this.txtStockQty.Location = new System.Drawing.Point(699, 33);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(85, 20);
            this.txtStockQty.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(566, 33);
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
            this.cmbStrength.Location = new System.Drawing.Point(375, 32);
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
            this.cmbGrind.Location = new System.Drawing.Point(248, 32);
            this.cmbGrind.Name = "cmbGrind";
            this.cmbGrind.Size = new System.Drawing.Size(121, 21);
            this.cmbGrind.TabIndex = 10;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(138, 33);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(100, 20);
            this.txtOrigin.TabIndex = 9;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(10, 33);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(121, 20);
            this.txtCoffeeName.TabIndex = 8;
            // 
            // tpLowStock
            // 
            this.tpLowStock.BackColor = System.Drawing.Color.Tan;
            this.tpLowStock.Controls.Add(this.btnUpdateStock);
            this.tpLowStock.Controls.Add(this.txtStockLevel);
            this.tpLowStock.Controls.Add(this.dtgLowStock);
            this.tpLowStock.Location = new System.Drawing.Point(4, 22);
            this.tpLowStock.Name = "tpLowStock";
            this.tpLowStock.Size = new System.Drawing.Size(806, 425);
            this.tpLowStock.TabIndex = 2;
            this.tpLowStock.Text = "Low stock ";
            // 
            // dtgLowStock
            // 
            this.dtgLowStock.AllowUserToAddRows = false;
            this.dtgLowStock.AllowUserToDeleteRows = false;
            this.dtgLowStock.AllowUserToResizeColumns = false;
            this.dtgLowStock.AllowUserToResizeRows = false;
            this.dtgLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLowStock.Location = new System.Drawing.Point(25, 31);
            this.dtgLowStock.MultiSelect = false;
            this.dtgLowStock.Name = "dtgLowStock";
            this.dtgLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLowStock.Size = new System.Drawing.Size(757, 222);
            this.dtgLowStock.TabIndex = 0;
            this.dtgLowStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLowStock_CellContentClick);
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.Location = new System.Drawing.Point(81, 332);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(100, 20);
            this.txtStockLevel.TabIndex = 1;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(187, 323);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(815, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUpdateStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).EndInit();
            this.tpLowStock.ResumeLayout(false);
            this.tpLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLowStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpAdd;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbUpdateCoffee;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuickSearch;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tpLowStock;
        private System.Windows.Forms.DataGridView dtgLowStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtStockLevel;
    }
}