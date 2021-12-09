
namespace TestdooProjekat.Views
{
    partial class ProductsEmployee
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
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnInsertNewSupplier = new System.Windows.Forms.Button();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.btnInsertNewProduct = new System.Windows.Forms.Button();
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
            this.label4.TabIndex = 26;
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
            this.label1.TabIndex = 25;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUpdateSupplier);
            this.panel1.Controls.Add(this.btnInsertNewSupplier);
            this.panel1.Controls.Add(this.btnUpdateProducts);
            this.panel1.Controls.Add(this.btnInsertNewProduct);
            this.panel1.Location = new System.Drawing.Point(111, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 456);
            this.panel1.TabIndex = 24;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUpdateSupplier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(469, 271);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(254, 46);
            this.btnUpdateSupplier.TabIndex = 50;
            this.btnUpdateSupplier.Text = "Update Suppliers";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnInsertNewSupplier
            // 
            this.btnInsertNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnInsertNewSupplier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertNewSupplier.Location = new System.Drawing.Point(388, 213);
            this.btnInsertNewSupplier.Name = "btnInsertNewSupplier";
            this.btnInsertNewSupplier.Size = new System.Drawing.Size(254, 46);
            this.btnInsertNewSupplier.TabIndex = 49;
            this.btnInsertNewSupplier.Text = "Insert New Supplier";
            this.btnInsertNewSupplier.UseVisualStyleBackColor = false;
            this.btnInsertNewSupplier.Click += new System.EventHandler(this.btnInsertNewSupplier_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUpdateProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateProducts.Location = new System.Drawing.Point(260, 151);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(254, 46);
            this.btnUpdateProducts.TabIndex = 48;
            this.btnUpdateProducts.Text = "Update Products";
            this.btnUpdateProducts.UseVisualStyleBackColor = false;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // btnInsertNewProduct
            // 
            this.btnInsertNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnInsertNewProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertNewProduct.Location = new System.Drawing.Point(114, 81);
            this.btnInsertNewProduct.Name = "btnInsertNewProduct";
            this.btnInsertNewProduct.Size = new System.Drawing.Size(254, 46);
            this.btnInsertNewProduct.TabIndex = 47;
            this.btnInsertNewProduct.Text = "Insert New Product";
            this.btnInsertNewProduct.UseVisualStyleBackColor = false;
            this.btnInsertNewProduct.Click += new System.EventHandler(this.btnInsertNewProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "You are logged in as ";
            // 
            // ProductsEmployee
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
            this.Name = "ProductsEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsEmployee";
            this.Load += new System.EventHandler(this.ProductsEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertNewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnInsertNewSupplier;
        private System.Windows.Forms.Button btnUpdateProducts;
    }
}