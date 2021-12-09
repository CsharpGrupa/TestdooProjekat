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
    public partial class ProductsEmployee : Form
    {
        public ProductsEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertNewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsEmployee_InserNewProduct newProduct = new ProductsEmployee_InserNewProduct();
            newProduct.Show();
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsEmployee_UpdateProduct updateProduct = new ProductsEmployee_UpdateProduct();
            updateProduct.Show();
        }

        private void btnInsertNewSupplier_Click(object sender, EventArgs e)
        {
            ProductsEmployee_InserNewSupplier insertNewSupplier = new ProductsEmployee_InserNewSupplier();
            insertNewSupplier.Show();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductsEmployee_Load(object sender, EventArgs e)
        {
            label2.Text += " Products Employee";
        }
    }
}
