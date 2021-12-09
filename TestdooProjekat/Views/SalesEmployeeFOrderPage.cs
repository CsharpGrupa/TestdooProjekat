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
    public enum StatusOrder { PrepareDelivery, Canceled, Sent, Delivered, Rejected }
    public partial class SalesEmployeeFOrderPage : Form
    {
        public int EmployeeId { get; set; }
        public SalesEmployeeFOrderPage(int empId)
        {
            InitializeComponent();
            EmployeeId = empId;
            txtEmpId.Text = empId.ToString();
            txtEmpId.ReadOnly = true;

        }
        public SalesEmployeeFOrderPage()
        {
            InitializeComponent();


        }
        TEST_DOOEntities db = new TEST_DOOEntities();
        private void SalesEmployeeFOrderPage_Load(object sender, EventArgs e)
        {
            GetOrderId();
            GetCustomerId();
            GetShippersId();
            GetStatusForOrder();
        }
        private void GetStatusForOrder()
        {
            foreach (var item in Enum.GetValues(typeof(StatusOrder)))
            {
                cbStatus.Items.Add(item);
            }
        }
        private void GetOrderId()
        {
            var id = db.Orders.Max(m => m.orderid);
            int idOrder = id + 1;
            txtOrderID.Enabled = false;
            txtOrderID.Text = idOrder.ToString();

        }
        private void GetShippersId()
        {
            List<Classes.ShipperClass> shippers = new List<Classes.ShipperClass>();
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                shippers = (from d in db.Shippers
                            select new Classes.ShipperClass
                            {
                                Id = d.shipperid,
                                Name = d.companyname
                            }).ToList();
                cbShipperId.DataSource = shippers;
                cbShipperId.DisplayMember = "Name";
                cbShipperId.ValueMember = "Id";
            }
        }
        private void GetCustomerId()
        {
            List<Classes.CustomerClass> customers = new List<Classes.CustomerClass>();
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                customers = (from d in db.Customers
                             select new Classes.CustomerClass
                             {
                                 Id = d.custid,
                                 Name = d.companyname
                             }).ToList();
            }
            cbCustId.DataSource = customers;
            cbCustId.DisplayMember = "Name";
            cbCustId.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        Order o = new Order();

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                o.orderid = Convert.ToInt32(txtOrderID.Text);
                o.custid = Convert.ToInt32(cbCustId.SelectedValue.ToString());
                // povuci podatak za empId iz logovanja
                o.empid =Convert.ToInt32(txtEmpId.Text);
                o.orderdate = dateTimePicker1.Value;
                o.requireddate = dateTimePickerBirth.Value;
                o.shippeddate = dateTimePickerHire.Value;
                o.shipperid = Convert.ToInt32(cbShipperId.SelectedValue.ToString());
                o.freight = Convert.ToDecimal(txtFreight.Text);
                o.shipname = txtShipName.Text;
                o.shipaddress = txtShipAddress.Text;
                o.shipcity = txtShipCity.Text;
                o.shipregion = txtShipRegion.Text;
                o.shippostalcode = shipPostalCode.Text;
                o.shipcountry = txtShipCountry.Text;
                o.status = cbStatus.SelectedItem.ToString();
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Orders.Add(o);
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully added");

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderID.Text);
            SalesNewOrder salesNewOrder = new SalesNewOrder(orderId);
            salesNewOrder.Show();

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

        private void label17_Click(object sender, EventArgs e)
        {
            SalesEmployee_MainPage page = new SalesEmployee_MainPage();
            this.Hide();
            page.Show();
        }
    }
}
