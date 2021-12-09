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
    public partial class LogisticEmployee_ViewShippers : Form
    {
        public LogisticEmployee_ViewShippers()
        {
            InitializeComponent();
        }

        private void LogisticEmployee_ViewShippers_Load(object sender, EventArgs e)
        {
            ShowAllShippers();
            dataGridViewShippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void ShowAllShippers()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewCustomers.AutoGenerateColumns = false;
                    dataGridViewShippers.DataSource = db.Shippers.ToList<Shipper>();
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
                txtIdShipper.Text = dataGridViewShippers.SelectedRows[0].Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridViewShippers.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dataGridViewShippers.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridViewShippers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowData();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Shipper shipper = new Shipper();
        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                try
                {
                    shipper.shipperid = Convert.ToInt32(txtIdShipper.Text);
                    shipper.companyname = txtCompanyName.Text;
                    shipper.phone = txtPhone.Text;
                    db.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    ShowAllShippers();
                    MessageBox.Show("Successfully updated.");
                    ClearBoxes();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void ClearBoxes()
        {
            txtIdShipper.Text = "Shipper ID";
            txtCompanyName.Text = "Company Name";
            txtPhone.Text = "Phone";
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

            LogisticEmployee lEmp = new LogisticEmployee();
            this.Hide();
            lEmp.Show();
        }
    }
}
