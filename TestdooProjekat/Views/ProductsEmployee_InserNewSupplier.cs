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
    public partial class ProductsEmployee_InserNewSupplier : Form
    {
        public ProductsEmployee_InserNewSupplier()
        {
            InitializeComponent();
        }

        private void ProductsEmployee_InserNewSupplier_Load(object sender, EventArgs e)
        {
            GetSupplierId();
        }
        private void GetSupplierId()
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var id = db.Suppliers.Max(m => m.supplierid);
            int idSupplier = id + 1;
            txtSupplierId.Enabled = false;
            txtSupplierId.Text = idSupplier.ToString();
        }

        Supplier supplier = new Supplier();
        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
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
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully added.");


            }
            catch (DBEntityValidationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnUpdateSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsEmployee_UpdateSuppliers suppliers = new ProductsEmployee_UpdateSuppliers();
            suppliers.Show();
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
            ProductsEmployee pEmp = new ProductsEmployee();
            this.Hide();
            pEmp.Show();
        }
    }
}
