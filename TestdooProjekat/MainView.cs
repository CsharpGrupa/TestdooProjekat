using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestdooProjekat.Views;

namespace TestdooProjekat
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private void GetSalesManagerPage()
        {
            SalesManager managerPage = new SalesManager();
            this.Hide();
            managerPage.Show();
        }
        //private void GetSalesEmployeePage()
        //{
        //    SalesEmployee_MainPage empPage = new SalesEmployee_MainPage();
        //    this.Hide();
        //    empPage.Show();
        //}
        private void GetLogisticEmployee()
        {
            LogisticEmployee lEmp = new LogisticEmployee();
            this.Hide();
            lEmp.Show();
        }
        private void GetProductsManager()
        {
            ProductManager productManager = new ProductManager();
            this.Hide();
            productManager.Show();
        }
        private void GetProductsEmployee()
        {
            ProductsEmployee productsEmployee = new ProductsEmployee();
            this.Hide();
            productsEmployee.Show();
        }
        private void GetLogisticManager()
        {
            LogisticManager lMan = new LogisticManager();
            this.Hide();
            lMan.Show();
        }
        private void GetHREmployee()
        {
            EmployeeHR empHr = new EmployeeHR();
            this.Hide();
            empHr.Show();
        }
        private void GetAdmin()
        {
            AdminPage admin = new AdminPage();
            this.Hide();
            admin.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            bool exist = u.ValidateUser(txtUsername.Text, txtPassword.Text);
            if (exist)
            {
                int employeeId = u.GetEmployeeID(txtUsername.Text);
                

                Role role = u.GetUserRole(txtUsername.Text);
                switch (role)
                {
                    case Role.SalesEmployee:
                        SalesEmployeeFOrderPage page = new SalesEmployeeFOrderPage(employeeId);
                        page.Show();
                        break;
                    case Role.SalesManager:
                       GetSalesManagerPage();
                        break;
                    case Role.LogisticEmployee:
                        GetLogisticEmployee();
                        break;
                    case Role.LogisticManager:
                        GetLogisticManager();
                        break;
                    case Role.ProductsEmployee:
                        GetProductsEmployee();
                        break;
                    case Role.HREmployee:
                        GetHREmployee();
                        break;
                    case Role.ProductsManager:
                        GetProductsManager();
                        break;
                    case Role.Admin:
                        GetAdmin();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
