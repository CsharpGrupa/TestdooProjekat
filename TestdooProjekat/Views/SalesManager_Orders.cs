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
    public partial class SalesManager_Orders : Form
    {
        public SalesManager_Orders()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalesManager_Orders_Load(object sender, EventArgs e)
        {
            ShowAllOrders();

        }
        TEST_DOOEntities db = new TEST_DOOEntities();
        private void SortByCustomer()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.custid);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }
        private void SortByCity()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.shipcity);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }
        private void SortByCountry()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.shipcountry);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }
        private void SortByRegion()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.shipregion);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }
        private void SortByPeriod()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.orderdate);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }
        private void SortByEmployee()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.empid);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }

        private void SortByStatus()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderByDescending(c => c.status);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }

        private void ShowAllOrders()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewCustomers.AutoGenerateColumns = false;
                    dataGridViewManagerSales.DataSource = db.Orders.ToList<Order>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void btnSortByClient_Click(object sender, EventArgs e)
        {
            SortByCustomer();

        }

        private void btnSortByCity_Click(object sender, EventArgs e)
        {
            SortByCity();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortByCountry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortByRegion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortByPeriod();
        }

        private void btnSortByEmployee_Click(object sender, EventArgs e)
        {
            SortByEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortByStatus();
        }
        private void Logout()
        {
            this.Hide();
            MainView mainPage = new MainView();
            mainPage.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
