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
     public enum statusUserr {active, deactived }
    public partial class AdminPage : Form
    {
        TEST_DOOEntities db = new TEST_DOOEntities();
        public AdminPage()
        {
            InitializeComponent();
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void ShowAllEmployeeId()
        {
            List<Classes.EmployeeClass> users = new List<Classes.EmployeeClass>();
            users = (from d in db.Employees
                     select new Classes.EmployeeClass
                     {
                         EmpId = d.empid,
                         Name = d.firstname,
                     }).ToList();
           
            cbEmpId.DataSource = users;
            cbEmpId.DisplayMember = "EmpId";
            cbEmpId.ValueMember = "EmpId";
            
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            GetUsers();
            GetEnumsInComboBox();
            ShowAllEmployeeId();
        }
        private void AddUser()
        {

        }
        private void GetEnumsInComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(Role)))
            {
                cbRole.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(statusUserr)))
            {
                cbStatus.Items.Add(item);
            }

        }

        private void GetUsers()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //dataGridViewUsers.AutoGenerateColumns = false;
                    dataGridViewUsers.DataSource = db.Users.ToList<User>();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataRow();
            cbEmpId.Enabled = false;
            btnAddUser.Enabled = false;
        }

        private void ShowDataRow()
        {
            try
            {
                txtUsername.Text = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
                txtPassword.Text = dataGridViewUsers.SelectedRows[0].Cells[7].Value.ToString();
                txtName.Text = dataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();
                cbRole.Text = dataGridViewUsers.SelectedRows[0].Cells[3].Value.ToString();
                cbEmpId.Text = dataGridViewUsers.SelectedRows[0].Cells[4].Value.ToString();
                cbStatus.Text = dataGridViewUsers.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void cbEmpId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtName.Text = cbEmpId.GetItemText(cbEmpId.SelectedValue);
            int txt = Convert.ToInt32(cbEmpId.GetItemText(cbEmpId.SelectedItem));
            //MessageBox.Show(txt.ToString());
            var emp = (from d in db.Users
                       where d.empid == txt
                       select d.lastname).FirstOrDefault();
            txtLastName.Text = emp.ToString();
            var empRole = (from d in db.Users
                           where d.empid == txt
                           select d.role).FirstOrDefault();
            cbRole.Text = empRole.ToString();

       
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView page = new MainView();
            page.Show();
        }
    }
}
