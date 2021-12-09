using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestdooProjekat.Views
{
    public partial class LogisticEmployee_InsertNewShipper : Form
    {
        public LogisticEmployee_InsertNewShipper()
        {
            InitializeComponent();
        }

        private void LogisticEmployee_InsertNewShipper_Load(object sender, EventArgs e)
        {
            GetShipperId();
        }
        private void GetShipperId()
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var id = db.Shippers.Max(m => m.shipperid);
            int idShipper = id + 1;
            txtIdShipper.Enabled = false;
            txtIdShipper.Text = idShipper.ToString();
        }

        private void txtCompanyName_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Shipper shipper = new Shipper();
        private void btnSaveShipper_Click(object sender, EventArgs e)
        {
            try
            {
                shipper.companyname = txtCompanyName.Text;
                shipper.phone = txtPhone.Text;
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Shippers.Add(shipper);
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully added shipper.");
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void label3_Click(object sender, EventArgs e)
        {
            LogisticEmployee lEmp = new LogisticEmployee();
            this.Hide();
            lEmp.Show();
        }
    }
}
