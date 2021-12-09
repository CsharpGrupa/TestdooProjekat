using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestdooProjekat.Views
{
  
    public partial class EmployeeHRUpdate : Form
    {

        public EmployeeHRUpdate()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Logout()
        {
            this.Hide();
            MainView mainPage = new MainView();
            mainPage.Show();
        }


        private void EmploteeHRUpdate_Load(object sender, EventArgs e)
        {
            ShowEnums();
            btnDelete.Enabled = false;
            btnEditEmployee.Enabled = false;
            
            ShowEmployees();

        }
        private void ShowEnums()
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
        public void ShowEmployees()
        {
            try
            {
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = db.Employees.ToList<Employee>();
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
                // nije radilo za redove koji imaju prazne celije
                //regulisano sa if 
                txtempid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxTitle.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxtitleofcourtesy.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                dateTimePickerBirth.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePickerHire.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtCity.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[9].Value != null)
                {
                    txtRegion.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                }
                else
                {
                    txtRegion.Text = " ";
                }
                txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtCountry.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtPhone.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[13].Value != null)
                {
                    comboBoxmgrid.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

                }
            }
            // napisati pravilno catch
            catch (Exception)
            {

                throw;
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEditEmployee.Enabled = true;    
            ShowRowData();
        }
        Employee emp = new Employee();
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                try
                {
                    emp.empid = Convert.ToInt32(txtempid.Text);
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
                    db.Entry(emp).State = EntityState.Modified;
                    db.SaveChanges();
                    
                    ShowEmployees();
                    MessageBox.Show("Successfully updated.");
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this? ", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    emp.empid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employeeid"].Value);
                    using (TEST_DOOEntities db = new TEST_DOOEntities())
                    {
                        emp = db.Employees.Where(x => x.empid == emp.empid).FirstOrDefault();
                        db.Entry(emp).State = EntityState.Deleted;
                        db.SaveChanges();
                        ShowEmployees();
                        MessageBox.Show("Successfully deleted.");

                    }
                }

               
            }
      
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHR emp = new EmployeeHR();
            emp.Show();
        }
    }
}
