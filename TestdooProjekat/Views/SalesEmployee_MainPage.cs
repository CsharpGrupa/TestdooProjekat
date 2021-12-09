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
    public partial class SalesEmployee_MainPage : Form
    {
        //public int EmployeeId { get; set; }
        public SalesEmployee_MainPage()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalesEmployee_MainPage_Load(object sender, EventArgs e)
        {
            label2.Text += " Sales Employee";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView main = new MainView();
            main.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesEmployeeFOrderPage page = new SalesEmployeeFOrderPage();
            page.Show();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPageForCustomers page = new SalesPageForCustomers();
            page.Show();
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_UpdateCustomers page = new Sales_UpdateCustomers();
            page.Show();
        }
    }
}
