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
    public partial class ProductsEmployee_UpdateProduct : Form
    {
        public ProductsEmployee_UpdateProduct()
        {
            InitializeComponent();
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductsEmployee_UpdateProduct_Load(object sender, EventArgs e)
        {
            ShowAllProducts();
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
        private void ShowAllProducts()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    dataGridViewProducts.DataSource = db.Products.ToList<Product>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
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
        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowData();
        }

        private void ShowRowData()
        {
            try
            {
                txtProductId.Text = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
                txtProductName.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxSupplierID.Text = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
                cbCategory.Text = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
                txtUnitprice.Text = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
                comboBoxDiscontinued.Text = dataGridViewProducts.SelectedRows[0].Cells[5].Value.ToString();
                txtStock.Text = dataGridViewProducts.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        Product p = new Product();
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                bool result;
                try
                {
                    p.productid = Convert.ToInt32(txtProductId.Text);
                    p.productname = txtProductName.Text;
                    p.supplierid = Convert.ToInt32(comboBoxSupplierID.SelectedValue.ToString());
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
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Successfully updated.");
                    ShowAllProducts();

                }
                catch (Exception)
                {

                    throw;
                }
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

        private void label2_Click(object sender, EventArgs e)
        {
            ProductsEmployee pEmp = new ProductsEmployee();
            this.Hide();
            pEmp.Show();
        }
    }
}
