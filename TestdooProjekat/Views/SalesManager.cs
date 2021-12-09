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
    public partial class SalesManager : Form
    {
        public SalesManager()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesManager_Orders orders = new SalesManager_Orders();
            orders.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void SalesManager_Load(object sender, EventArgs e)
        {
            User u = new User();


            label2.Text += "Sales Manager";
        }
    }
}
