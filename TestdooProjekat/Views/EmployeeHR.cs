using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestdooProjekat.Views
{
    public partial class EmployeeHR : Form
    {     
        public EmployeeHR()
        {
            InitializeComponent();
        }


        private void Logout()
        {
            this.Hide();
            MainView mainPage = new MainView();
            mainPage.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHR_InsertNewEmp newEmp = new EmployeeHR_InsertNewEmp();
            newEmp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeHR_Load(object sender, EventArgs e)
        {
            label2.Text += " HR Employee";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUE_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHRUpdate eupdate = new EmployeeHRUpdate();
            eupdate.Show();
        }
    }
}
