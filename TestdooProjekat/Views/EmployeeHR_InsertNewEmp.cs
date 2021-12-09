using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestdooProjekat.Views
{
    //dodati jos polja
    public enum Title { Mr, Ms, Mrs, Dr}
    public partial class EmployeeHR_InsertNewEmp : Form
    {
        public EmployeeHR_InsertNewEmp()
        {
            InitializeComponent();
        }
        
        private void EmployeeHR_InsertNewEmp_Load(object sender, EventArgs e)
        {
            
            foreach (var item in Enum.GetValues(typeof(Role)))
            {
                comboBoxTitle.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Title)))
            {
                comboBoxtitleofcourtesy.Items.Add(item);
            }
        }
       
        Employee emp = new Employee();
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                emp.lastname = txtLastName.Text;
                emp.firstname = txtFirstName.Text;
                emp.title = comboBoxTitle.SelectedItem.ToString();
                emp.titleofcourtesy = comboBoxtitleofcourtesy.SelectedItem.ToString();
                emp.birthdate = dateTimePickerBirth.Value;
                emp.hiredate = dateTimePickerHire.Value;
                emp.address = txtAddress.Text;
                emp.city = txtCity.Text;
                emp.region = txtRegion.Text;
                emp.postalcode = txtPostalCode.Text;
                emp.country = txtCountry.Text;
                emp.phone = txtPhone.Text;
                emp.mgrid = Convert.ToInt32(comboBoxmgrid.SelectedItem.ToString());
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    
                    db.Employees.Add(emp);
                    db.SaveChanges();

                }
                MessageBox.Show("Successfully added.");
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHRUpdate emp = new EmployeeHRUpdate();
            emp.Show();
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            
            txtLastName.Text = "";
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
        }

        private void txtCity_Click(object sender, EventArgs e)
        {
            txtCity.Text = "";
        }

        private void txtRegion_Click(object sender, EventArgs e)
        {
            txtRegion.Text = "";
        }

        private void txtPostalCode_Click(object sender, EventArgs e)
        {
            txtPostalCode.Text = "";
        }

        private void txtCountry_Click(object sender, EventArgs e)
        {
            txtCountry.Text = "";
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
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
            this.Hide();
            EmployeeHR emp = new EmployeeHR();
            emp.Show();
        }
    }
}
