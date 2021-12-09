using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestdooProjekat.Views
{
    public partial class Sales_UpdateCustomers : Form
    {
        Customer customer = new Customer();
        public Sales_UpdateCustomers()
        {

            InitializeComponent();
        }

        private void Sales_UpdateCustomers_Load(object sender, EventArgs e)
        {
            ShowCustomers();
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void ShowCustomers()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewCustomers.AutoGenerateColumns = false;
                    dataGridViewCustomers.DataSource = db.Customers.ToList<Customer>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
        private void ShowRowData()
        {
            try
            {
                txtCustId.Text = dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString();
                txtContactName.Text = dataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString();
                txtContactTitle.Text = dataGridViewCustomers.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = dataGridViewCustomers.SelectedRows[0].Cells[4].Value.ToString();
                txtCity.Text = dataGridViewCustomers.SelectedRows[0].Cells[5].Value.ToString();
                if (dataGridViewCustomers.CurrentRow.Cells[6].Value != null)
                {
                    txtRegion.Text = dataGridViewCustomers.SelectedRows[0].Cells[6].Value.ToString();
                }
                else
                {
                    txtRegion.Text = " ";
                }
                txtPostalCode.Text = dataGridViewCustomers.SelectedRows[0].Cells[7].Value.ToString();
                txtCountry.Text = dataGridViewCustomers.SelectedRows[0].Cells[8].Value.ToString();
                txtPhone.Text = dataGridViewCustomers.SelectedRows[0].Cells[9].Value.ToString();
                if (dataGridViewCustomers.CurrentRow.Cells[10].Value != null)
                {
                    txtFax.Text = dataGridViewCustomers.SelectedRows[0].Cells[10].Value.ToString();

                }
                else
                {
                    txtFax.Text = " ";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowData();
        }

        private void btnUpdateAddressCustomer_Click(object sender, EventArgs e)
        {
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                try
                {
                    customer.custid = Convert.ToInt32(txtCustId.Text);
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
                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                    ShowCustomers();
                    MessageBox.Show("Successfully updated.");
                    ClearBoxes();
                    
                }
                catch (DbEntityValidationException ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void ClearBoxes()
        {
            txtCustId.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
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

        private void label2_Click(object sender, EventArgs e)
        {
            SalesEmployee_MainPage page = new SalesEmployee_MainPage();
            this.Hide();
            page.Show();
        }
    }
}
