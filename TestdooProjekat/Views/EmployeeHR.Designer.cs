
namespace TestdooProjekat.Views
{
    partial class EmployeeHR
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnUE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "You are logged in as ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNE
            // 
            this.btnNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnNE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNE.Location = new System.Drawing.Point(235, 133);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(298, 75);
            this.btnNE.TabIndex = 14;
            this.btnNE.Text = "Insert new Employee";
            this.btnNE.UseVisualStyleBackColor = false;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // btnUE
            // 
            this.btnUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUE.Location = new System.Drawing.Point(235, 263);
            this.btnUE.Name = "btnUE";
            this.btnUE.Size = new System.Drawing.Size(298, 75);
            this.btnUE.TabIndex = 15;
            this.btnUE.Text = "Update Employee";
            this.btnUE.UseVisualStyleBackColor = false;
            this.btnUE.Click += new System.EventHandler(this.btnUE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUE);
            this.panel1.Controls.Add(this.btnNE);
            this.panel1.Location = new System.Drawing.Point(112, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 456);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(34, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(863, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmployeeHR
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
            this.Name = "EmployeeHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeHR";
            this.Load += new System.EventHandler(this.EmployeeHR_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnUE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}