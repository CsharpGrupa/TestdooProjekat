
namespace TestdooProjekat.Views
{
    partial class ProductsEmployee_UpdateProduct
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.comboBoxDiscontinued = new System.Windows.Forms.ComboBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.comboBoxSupplierID = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(854, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 77;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(302, 36);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(574, 502);
            this.dataGridViewProducts.TabIndex = 76;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(75, 252);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(130, 28);
            this.cbCategory.TabIndex = 84;
            this.cbCategory.Text = "CategoryId";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtStock.Location = new System.Drawing.Point(75, 401);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(130, 26);
            this.txtStock.TabIndex = 83;
            this.txtStock.Text = "Stock";
            // 
            // comboBoxDiscontinued
            // 
            this.comboBoxDiscontinued.BackColor = System.Drawing.Color.White;
            this.comboBoxDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxDiscontinued.FormattingEnabled = true;
            this.comboBoxDiscontinued.Location = new System.Drawing.Point(75, 352);
            this.comboBoxDiscontinued.Name = "comboBoxDiscontinued";
            this.comboBoxDiscontinued.Size = new System.Drawing.Size(130, 28);
            this.comboBoxDiscontinued.TabIndex = 82;
            this.comboBoxDiscontinued.Text = "Discontinued";
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.BackColor = System.Drawing.Color.White;
            this.txtUnitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtUnitprice.Location = new System.Drawing.Point(75, 299);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(130, 26);
            this.txtUnitprice.TabIndex = 81;
            this.txtUnitprice.Text = "Unit Price";
            // 
            // comboBoxSupplierID
            // 
            this.comboBoxSupplierID.BackColor = System.Drawing.Color.White;
            this.comboBoxSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxSupplierID.FormattingEnabled = true;
            this.comboBoxSupplierID.Location = new System.Drawing.Point(75, 207);
            this.comboBoxSupplierID.Name = "comboBoxSupplierID";
            this.comboBoxSupplierID.Size = new System.Drawing.Size(130, 28);
            this.comboBoxSupplierID.TabIndex = 80;
            this.comboBoxSupplierID.Text = "Supplier ID";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtProductName.Location = new System.Drawing.Point(75, 152);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(130, 26);
            this.txtProductName.TabIndex = 79;
            this.txtProductName.Text = "Product Name";
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.White;
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtProductId.Location = new System.Drawing.Point(75, 90);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(130, 26);
            this.txtProductId.TabIndex = 78;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.White;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateProduct.Location = new System.Drawing.Point(75, 451);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(139, 46);
            this.btnUpdateProduct.TabIndex = 85;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "< Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductsEmployee_UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.comboBoxDiscontinued);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.comboBoxSupplierID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsEmployee_UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsEmployee_UpdateProduct";
            this.Load += new System.EventHandler(this.ProductsEmployee_UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox comboBoxDiscontinued;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.ComboBox comboBoxSupplierID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}