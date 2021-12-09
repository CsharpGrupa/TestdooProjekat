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
    public partial class ProductsEmployee_UpdateSuppliers : Form
    {
        public ProductsEmployee_UpdateSuppliers()
        {
            InitializeComponent();
        }

        private void ProductsEmployee_UpdateSuppliers_Load(object sender, EventArgs e)
        {
            ShowSuppliers();
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void ShowSuppliers()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewCustomers.AutoGenerateColumns = false;
                    dataGridViewSuppliers.DataSource = db.Suppliers.ToList<Supplier>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowData();
        }
        private void ShowRowData()
        {
            try
            {
                txtSupplierId.Text =  dataGridViewSuppliers.SelectedRows[0].Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridViewSuppliers.SelectedRows[0].Cells[1].Value.ToString();
                txtContactName.Text = dataGridViewSuppliers.SelectedRows[0].Cells[2].Value.ToString();
                txtContactTitle.Text = dataGridViewSuppliers.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = dataGridViewSuppliers.SelectedRows[0].Cells[4].Value.ToString();
                txtCity.Text = dataGridViewSuppliers.SelectedRows[0].Cells[5].Value.ToString();
                if (dataGridViewSuppliers.CurrentRow.Cells[6].Value != null)
                {
                    txtRegion.Text = dataGridViewSuppliers.SelectedRows[0].Cells[6].Value.ToString();
                }
                else
                {
                    txtRegion.Text = " ";
                }
                txtPostalCode.Text = dataGridViewSuppliers.SelectedRows[0].Cells[7].Value.ToString();
                txtCountry.Text = dataGridViewSuppliers.SelectedRows[0].Cells[8].Value.ToString();
                txtPhone.Text = dataGridViewSuppliers.SelectedRows[0].Cells[9].Value.ToString();
                if (dataGridViewSuppliers.CurrentRow.Cells[10].Value != null)
                {
                    txtFax.Text = dataGridViewSuppliers.SelectedRows[0].Cells[10].Value.ToString();

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
        Supplier supplier = new Supplier();
        private void btnUpdateSuppliers_Click(object sender, EventArgs e)
        {
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                try
                {
                    supplier.supplierid = Convert.ToInt32(txtSupplierId.Text);
                    supplier.companyname = txtCompanyName.Text;
                    supplier.contactname = txtContactName.Text;
                    supplier.contacttitle = txtContactTitle.Text;
                    supplier.address = txtAddress.Text;
                    supplier.city = txtCity.Text;
                    supplier.region = txtRegion.Text;
                    supplier.postalcode = txtPostalCode.Text;
                    supplier.country = txtCountry.Text;
                    supplier.phone = txtPhone.Text;
                    supplier.fax = txtFax.Text;
                    db.Entry(supplier).State = EntityState.Modified;
                    db.SaveChanges();
                    ShowSuppliers();
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
            txtSupplierId.Text = "Supplier Id";
            txtCompanyName.Text = "Company Name";
            txtContactName.Text = "Contact Name";
            txtContactTitle.Text = "Contact Title";
            txtAddress.Text = "Address";
            txtCity.Text = "City";
            txtRegion.Text = "Region";
            txtPostalCode.Text = "Postal Code";
            txtCountry.Text = "Country";
            txtPhone.Text = "Phone";
            txtFax.Text = "Fax";
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
            ProductsEmployee pEmp = new ProductsEmployee();
            this.Hide();
            pEmp.Show();
        }
    }
}
