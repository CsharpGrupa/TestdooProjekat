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
    public partial class LogisticManager : Form
    {
        public LogisticManager()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogisticManager_OrdersView logisticManager_Orders = new LogisticManager_OrdersView();
            logisticManager_Orders.Show();
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

        private void LogisticManager_Load(object sender, EventArgs e)
        {
            label2.Text += " Logistic Manager";
        }
    }
}
