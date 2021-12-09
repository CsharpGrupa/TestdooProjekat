
namespace TestdooProjekat.Views
{
    partial class LogisticEmployee_ViewShippers
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
            this.dataGridViewShippers = new System.Windows.Forms.DataGridView();
            this.txtIdShipper = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShippers
            // 
            this.dataGridViewShippers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippers.Location = new System.Drawing.Point(299, 36);
            this.dataGridViewShippers.Name = "dataGridViewShippers";
            this.dataGridViewShippers.Size = new System.Drawing.Size(574, 502);
            this.dataGridViewShippers.TabIndex = 75;
            this.dataGridViewShippers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShippers_CellContentClick);
            // 
            // txtIdShipper
            // 
            this.txtIdShipper.BackColor = System.Drawing.Color.White;
            this.txtIdShipper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdShipper.Enabled = false;
            this.txtIdShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIdShipper.Location = new System.Drawing.Point(79, 154);
            this.txtIdShipper.Name = "txtIdShipper";
            this.txtIdShipper.Size = new System.Drawing.Size(130, 26);
            this.txtIdShipper.TabIndex = 78;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPhone.Location = new System.Drawing.Point(79, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 26);
            this.txtPhone.TabIndex = 77;
            this.txtPhone.Text = "Phone";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(79, 198);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(130, 26);
            this.txtCompanyName.TabIndex = 76;
            this.txtCompanyName.Text = "Company Name";
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.BackColor = System.Drawing.Color.White;
            this.btnUpdateShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUpdateShipper.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateShipper.Location = new System.Drawing.Point(93, 372);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(139, 46);
            this.btnUpdateShipper.TabIndex = 79;
            this.btnUpdateShipper.Text = "Update";
            this.btnUpdateShipper.UseVisualStyleBackColor = false;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(863, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "< Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogisticEmployee_ViewShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateShipper);
            this.Controls.Add(this.txtIdShipper);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dataGridViewShippers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogisticEmployee_ViewShippers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogisticEmployee_ViewShippers";
            this.Load += new System.EventHandler(this.LogisticEmployee_ViewShippers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShippers;
        private System.Windows.Forms.TextBox txtIdShipper;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}