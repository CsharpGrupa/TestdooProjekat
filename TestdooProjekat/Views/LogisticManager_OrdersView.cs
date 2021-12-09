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
    public partial class LogisticManager_OrdersView : Form
    {
        public LogisticManager_OrdersView()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void LogisticManager_OrdersView_Load(object sender, EventArgs e)
        {
            ShowAllOrders();
        }
        TEST_DOOEntities db = new TEST_DOOEntities();
        private void SortByShipper()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderBy(c => c.shipperid);
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
                             select d).OrderByDescending(c => c.shipregion);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }

      

        private void SortByPeriod()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderByDescending(c => c.shippeddate);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }


        private void SortByStatus()
        {
            var orderSort = (from d in db.Orders
                             select d).OrderByDescending(c => c.status);
            dataGridViewManagerSales.DataSource = orderSort.ToList();
        }

        private void btnSortByShipper_Click_1(object sender, EventArgs e)
        {
            SortByShipper();

        }

        private void btnSortbyCountry_Click_1(object sender, EventArgs e)
        {
            SortByCountry();

        }

        private void btnSortbyRegion_Click_1(object sender, EventArgs e)
        {
            SortByRegion();

        }

        private void btnSortByPeriod_Click_1(object sender, EventArgs e)
        {
            SortByPeriod();

        }

        private void btnSortByStatus_Click_1(object sender, EventArgs e)
        {
            SortByStatus();

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
            LogisticManager lm = new LogisticManager();
            this.Hide();
            lm.Show();
        }
    }
}
