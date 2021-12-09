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
    public partial class EmployeeSalesPage : Form
    {
        public EmployeeSalesPage()
        {
            InitializeComponent();
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPageForCustomers pageCust = new SalesPageForCustomers();
            pageCust.Show();
        }
        private void Logout()
        {
            this.Hide();
            MainView mainPage = new MainView();
            mainPage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            SalesEmployeeFOrderPage order = new SalesEmployeeFOrderPage();
            this.Hide();
            order.Show();
        }
    }
}
