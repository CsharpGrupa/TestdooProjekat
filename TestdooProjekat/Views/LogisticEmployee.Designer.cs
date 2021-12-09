
namespace TestdooProjekat.Views
{
    partial class LogisticEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewShippers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(862, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(20, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "You are logged in as ";
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnAddShipper.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddShipper.Location = new System.Drawing.Point(134, 182);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(273, 46);
            this.btnAddShipper.TabIndex = 47;
            this.btnAddShipper.Text = "Insert new Shipper";
            this.btnAddShipper.UseVisualStyleBackColor = false;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnViewShippers);
            this.panel1.Controls.Add(this.btnAddShipper);
            this.panel1.Location = new System.Drawing.Point(110, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 456);
            this.panel1.TabIndex = 26;
            // 
            // btnViewShippers
            // 
            this.btnViewShippers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewShippers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewShippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnViewShippers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewShippers.Location = new System.Drawing.Point(325, 267);
            this.btnViewShippers.Name = "btnViewShippers";
            this.btnViewShippers.Size = new System.Drawing.Size(273, 46);
            this.btnViewShippers.TabIndex = 48;
            this.btnViewShippers.Text = "View all Shippers";
            this.btnViewShippers.UseVisualStyleBackColor = false;
            this.btnViewShippers.Click += new System.EventHandler(this.btnViewShippers_Click);
            // 
            // LogisticEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogisticEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogisticEmployee";
            this.Load += new System.EventHandler(this.LogisticEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewShippers;
    }
}