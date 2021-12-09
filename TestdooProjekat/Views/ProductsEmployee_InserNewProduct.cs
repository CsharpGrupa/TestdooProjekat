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
    public partial class ProductsEmployee_InserNewProduct : Form
    {
        public ProductsEmployee_InserNewProduct()
        {
            InitializeComponent();
        }
        TEST_DOOEntities db = new TEST_DOOEntities();
        Product p = new Product();
        private void GetProductID()
        {
            var id = db.Products.Max(m => m.productid);
            int idProduct = id + 1;
            txtProductId.Enabled = false;
            txtProductId.Text = idProduct.ToString();
        }
        private void ProductsEmployee_InserNewProduct_Load(object sender, EventArgs e)
        {
            GetProductID();
            ShowSuppliers();
            DiscontinuedShow();
            ShowCategoryId();
        }
        private void ShowCategoryId()
        {
            List<Classes.CategoryClass> categoryClasses = new List<Classes.CategoryClass>();
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                categoryClasses = (from d in db.Categories
                                   select new Classes.CategoryClass
                                   {
                                       Id = d.categoryid,
                                       Name = d.categoryname
                                   }).ToList();
            }
            cbCategory.DataSource = categoryClasses;
            cbCategory.DisplayMember = "Id";
            cbCategory.ValueMember = "Id";
        }

        private void ShowSuppliers()
        {
            List<Classes.SupplierClass> listSuppliers = new List<Classes.SupplierClass>();
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                listSuppliers = (from d in db.Suppliers
                                 select new Classes.SupplierClass
                                 {
                                     Id = d.supplierid,
                                     Name = d.companyname
                                 }).ToList();
            }
            comboBoxSupplierID.DataSource = listSuppliers;
            comboBoxSupplierID.DisplayMember = "Name";
            comboBoxSupplierID.ValueMember = "Id";
        }
        private void DiscontinuedShow()
        {
            comboBoxDiscontinued.Items.Add("1");
            comboBoxDiscontinued.Items.Add("0");
        }
        private void txtProductName_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            bool result = true;
            try
            {
                p.productid = Convert.ToInt32(txtProductId.Text);
                p.productname = txtProductName.Text;
                p.supplierid =Convert.ToInt32(comboBoxSupplierID.SelectedValue.ToString());
                p.categoryid = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                p.unitprice = Convert.ToDecimal(txtUnitprice.Text);
                string prod = comboBoxDiscontinued.GetItemText(comboBoxDiscontinued.SelectedItem);
                if (String.Compare(prod, "1") == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                p.discontinued = result;
                p.stock = Convert.ToInt32(txtStock.Text);
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully added product.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBoxSupplierID_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsEmployee_UpdateProduct updateProduct = new ProductsEmployee_UpdateProduct();
            updateProduct.Show();
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
