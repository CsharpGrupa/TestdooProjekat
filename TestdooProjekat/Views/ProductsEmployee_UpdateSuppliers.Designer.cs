
namespace TestdooProjekat.Views
{
    partial class ProductsEmployee_UpdateSuppliers
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
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpdateSuppliers = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(863, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(21, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(316, 43);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(574, 502);
            this.dataGridViewSuppliers.TabIndex = 77;
            this.dataGridViewSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellContentClick);
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.BackColor = System.Drawing.Color.White;
            this.txtSupplierId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSupplierId.Location = new System.Drawing.Point(25, 72);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(130, 26);
            this.txtSupplierId.TabIndex = 89;
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.Color.White;
            this.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtContactName.Location = new System.Drawing.Point(25, 136);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(130, 26);
            this.txtContactName.TabIndex = 88;
            this.txtContactName.Text = "Contact Name";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtFax.Location = new System.Drawing.Point(25, 442);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(130, 26);
            this.txtFax.TabIndex = 87;
            this.txtFax.Text = "Fax";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddress.Location = new System.Drawing.Point(25, 204);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(130, 26);
            this.txtAddress.TabIndex = 86;
            this.txtAddress.Text = "Address";
            // 
            // btnUpdateSuppliers
            // 
            this.btnUpdateSuppliers.BackColor = System.Drawing.Color.White;
            this.btnUpdateSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpdateSuppliers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateSuppliers.Location = new System.Drawing.Point(138, 488);
            this.btnUpdateSuppliers.Name = "btnUpdateSuppliers";
            this.btnUpdateSuppliers.Size = new System.Drawing.Size(160, 46);
            this.btnUpdateSuppliers.TabIndex = 85;
            this.btnUpdateSuppliers.Text = "Update Suppliers";
            this.btnUpdateSuppliers.UseVisualStyleBackColor = false;
            this.btnUpdateSuppliers.Click += new System.EventHandler(this.btnUpdateSuppliers_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPhone.Location = new System.Drawing.Point(25, 405);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 26);
            this.txtPhone.TabIndex = 84;
            this.txtPhone.Text = "Phone";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCountry.Location = new System.Drawing.Point(25, 375);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(130, 26);
            this.txtCountry.TabIndex = 83;
            this.txtCountry.Text = "Country";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.White;
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPostalCode.Location = new System.Drawing.Point(25, 320);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(130, 26);
            this.txtPostalCode.TabIndex = 82;
            this.txtPostalCode.Text = "PostalCode";
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.White;
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtRegion.Location = new System.Drawing.Point(25, 271);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(130, 26);
            this.txtRegion.TabIndex = 81;
            this.txtRegion.Text = "Region";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCity.Location = new System.Drawing.Point(25, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(130, 26);
            this.txtCity.TabIndex = 80;
            this.txtCity.Text = "City";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BackColor = System.Drawing.Color.White;
            this.txtContactTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtContactTitle.Location = new System.Drawing.Point(25, 167);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(130, 26);
            this.txtContactTitle.TabIndex = 79;
            this.txtContactTitle.Text = "Contact Title";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(25, 104);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(130, 26);
            this.txtCompanyName.TabIndex = 78;
            this.txtCompanyName.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 90;
            this.label3.Text = "< Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProductsEmployee_UpdateSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnUpdateSuppliers);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsEmployee_UpdateSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsEmployee_UpdateSuppliers";
            this.Load += new System.EventHandler(this.ProductsEmployee_UpdateSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUpdateSuppliers;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
    }
}