
namespace TestdooProjekat.Views
{
    partial class ProductsEmployee_InserNewProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.comboBoxDiscontinued = new System.Windows.Forms.ComboBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.comboBoxSupplierID = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(863, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(21, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.btnViewProducts);
            this.panel1.Controls.Add(this.btnSaveProduct);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.comboBoxDiscontinued);
            this.panel1.Controls.Add(this.txtUnitprice);
            this.panel1.Controls.Add(this.comboBoxSupplierID);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductId);
            this.panel1.Location = new System.Drawing.Point(111, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 456);
            this.panel1.TabIndex = 32;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(58, 211);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(130, 28);
            this.cbCategory.TabIndex = 50;
            this.cbCategory.Text = "CategoryId";
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnViewProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewProducts.Location = new System.Drawing.Point(524, 238);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(160, 46);
            this.btnViewProducts.TabIndex = 49;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSaveProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveProduct.Location = new System.Drawing.Point(524, 148);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(139, 46);
            this.btnSaveProduct.TabIndex = 48;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtStock.Location = new System.Drawing.Point(58, 360);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(130, 26);
            this.txtStock.TabIndex = 40;
            this.txtStock.Text = "Stock";
            this.txtStock.Click += new System.EventHandler(this.txtProductName_Click);
            // 
            // comboBoxDiscontinued
            // 
            this.comboBoxDiscontinued.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxDiscontinued.FormattingEnabled = true;
            this.comboBoxDiscontinued.Location = new System.Drawing.Point(58, 311);
            this.comboBoxDiscontinued.Name = "comboBoxDiscontinued";
            this.comboBoxDiscontinued.Size = new System.Drawing.Size(130, 28);
            this.comboBoxDiscontinued.TabIndex = 39;
            this.comboBoxDiscontinued.Text = "Discontinued";
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUnitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtUnitprice.Location = new System.Drawing.Point(58, 258);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(130, 26);
            this.txtUnitprice.TabIndex = 38;
            this.txtUnitprice.Text = "Unit Price";
            this.txtUnitprice.Click += new System.EventHandler(this.txtProductName_Click);
            // 
            // comboBoxSupplierID
            // 
            this.comboBoxSupplierID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxSupplierID.FormattingEnabled = true;
            this.comboBoxSupplierID.Location = new System.Drawing.Point(58, 166);
            this.comboBoxSupplierID.Name = "comboBoxSupplierID";
            this.comboBoxSupplierID.Size = new System.Drawing.Size(130, 28);
            this.comboBoxSupplierID.TabIndex = 37;
            this.comboBoxSupplierID.Text = "Supplier ID";
            this.comboBoxSupplierID.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSupplierID_SelectionChangeCommitted);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtProductName.Location = new System.Drawing.Point(58, 111);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(130, 26);
            this.txtProductName.TabIndex = 36;
            this.txtProductName.Text = "Product Name";
            this.txtProductName.Click += new System.EventHandler(this.txtProductName_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtProductId.Location = new System.Drawing.Point(58, 49);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(130, 26);
            this.txtProductId.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "< Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductsEmployee_InserNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsEmployee_InserNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsEmployee_InserNewProduct";
            this.Load += new System.EventHandler(this.ProductsEmployee_InserNewProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox comboBoxDiscontinued;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.ComboBox comboBoxSupplierID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}