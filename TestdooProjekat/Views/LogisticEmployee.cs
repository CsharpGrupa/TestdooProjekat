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
    public partial class LogisticEmployee : Form
    {
        public LogisticEmployee()
        {
            InitializeComponent();
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogisticEmployee_InsertNewShipper newShipper = new LogisticEmployee_InsertNewShipper();
            newShipper.Show();
        }

        private void btnViewShippers_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogisticEmployee_ViewShippers viewShipper = new LogisticEmployee_ViewShippers();
            viewShipper.Show();
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

        private void LogisticEmployee_Load(object sender, EventArgs e)
        {
            label2.Text += "Logistic Employee";
        }
    }
}
