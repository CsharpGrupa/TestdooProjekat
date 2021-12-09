
namespace TestdooProjekat.Views
{
    partial class ProductManager
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
            this.dataGridViewManagerProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.btnSortbySupplier = new System.Windows.Forms.Button();
            this.btnSortbyStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManagerProducts
            // 
            this.dataGridViewManagerProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManagerProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagerProducts.Location = new System.Drawing.Point(12, 14);
            this.dataGridViewManagerProducts.Name = "dataGridViewManagerProducts";
            this.dataGridViewManagerProducts.Size = new System.Drawing.Size(620, 463);
            this.dataGridViewManagerProducts.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(855, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortByDate.Location = new System.Drawing.Point(705, 84);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(152, 32);
            this.btnSortByDate.TabIndex = 28;
            this.btnSortByDate.Text = "Sort By Date";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // btnSortbySupplier
            // 
            this.btnSortbySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortbySupplier.Location = new System.Drawing.Point(705, 126);
            this.btnSortbySupplier.Name = "btnSortbySupplier";
            this.btnSortbySupplier.Size = new System.Drawing.Size(152, 32);
            this.btnSortbySupplier.TabIndex = 29;
            this.btnSortbySupplier.Text = "Sort By Supplier";
            this.btnSortbySupplier.UseVisualStyleBackColor = true;
            this.btnSortbySupplier.Click += new System.EventHandler(this.btnSortbySupplier_Click);
            // 
            // btnSortbyStatus
            // 
            this.btnSortbyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortbyStatus.Location = new System.Drawing.Point(705, 165);
            this.btnSortbyStatus.Name = "btnSortbyStatus";
            this.btnSortbyStatus.Size = new System.Drawing.Size(152, 32);
            this.btnSortbyStatus.TabIndex = 30;
            this.btnSortbyStatus.Text = "Sort By Status";
            this.btnSortbyStatus.UseVisualStyleBackColor = true;
            this.btnSortbyStatus.Click += new System.EventHandler(this.btnSortbyStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortbyStatus);
            this.Controls.Add(this.btnSortbySupplier);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewManagerProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManagerProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Button btnSortbySupplier;
        private System.Windows.Forms.Button btnSortbyStatus;
        private System.Windows.Forms.Label label1;
    }
}