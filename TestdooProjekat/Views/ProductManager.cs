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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            ShowAllOrders();
            ShowAllOrders();
            FillComboBoxSort();
        }
        Order order = new Order();
        private void ShowAllOrders()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewCustomers.AutoGenerateColumns = false;
                    dataGridViewManagerProducts.DataSource = db.Orders.ToList<Order>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
        private void FillComboBoxSort()
        {
            //cbSort.Items.Add("Supplier");
            //cbSort.Items.Add("Insert period");
            //cbSort.Items.Add("Order status");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        TEST_DOOEntities db = new TEST_DOOEntities();
        private void cbSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //List<Order> orders = new List<Order>();
            //var ordersFromBase = (from o in db.Orders
            //                      select o).ToList();
            //foreach (Order item in ordersFromBase)
            //{
            //    orders.Add(item);
            //}

        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            var orderr = (from d in db.Orders
                          select d).OrderBy(c => c.orderdate);
            dataGridViewManagerProducts.DataSource = orderr.ToList();

            
        }

        private void btnSortbySupplier_Click(object sender, EventArgs e)
        {
            var orderr = (from d in db.Orders
                          select d).OrderBy(c => c.shipperid);
            dataGridViewManagerProducts.DataSource = orderr.ToList();
        }

        private void btnSortbyStatus_Click(object sender, EventArgs e)
        {
            var orderr = (from d in db.Orders
                          select d).OrderBy(c => c.status);
            dataGridViewManagerProducts.DataSource = orderr.ToList();
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
    }
}
