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
    public partial class SalesPageForCustomers : Form
    {
        public SalesPageForCustomers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Customer customer = new Customer();

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                customer.companyname = txtCompanyName.Text;
                customer.contactname = txtContactName.Text;
                customer.contacttitle = txtContactTitle.Text;
                customer.address = txtAddress.Text;
                customer.city = txtCity.Text;
                customer.region = txtRegion.Text;
                customer.postalcode = txtPostalCode.Text;
                customer.country = txtCountry.Text;
                customer.phone = txtPhone.Text;
                customer.fax = txtFax.Text;
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully added.");


            }
            catch (DBEntityValidationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SalesPageForCustomers_Load(object sender, EventArgs e)
        {
            


        }

        private void btnUpdateCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_UpdateCustomers updateCustomers = new Sales_UpdateCustomers();
            updateCustomers.Show();
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

        private void label17_Click(object sender, EventArgs e)
        {
            SalesEmployee_MainPage page = new SalesEmployee_MainPage();
            this.Hide();
            page.Show();
        }
    }
}
