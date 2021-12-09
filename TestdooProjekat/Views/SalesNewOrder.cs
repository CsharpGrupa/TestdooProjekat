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
    
    public partial class SalesNewOrder : Form
    {
        public int OrderId { get; set; }
        public SalesNewOrder(int orderId)
        {
            InitializeComponent();
            OrderId = orderId;
            txtOrderID.Text = orderId.ToString();
            txtOrderID.ReadOnly = true;
            
        }
        
        TEST_DOOEntities db = new TEST_DOOEntities();
        private void SalesNewOrder_Load(object sender, EventArgs e)
        {
            Clear();
            ShowCategoriesAndProducts();
            //GetOrderId();
            dt.Columns.Add("OrderId");
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UnitPrice");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Discount");
        }
      
        private void Clear()
        {
            cbCategory.Text = "Select category";
            cbProduct.Text = "Select Product";
            txtQty.Text = "Insert Quantity";
            txtPrice.Enabled = false;
            txtPrice.Text = "";
            txtavbitm.Text = "";
            txtavbitm.Enabled = false;
            txtDiscount.Text = "";

        }

        private void ShowCategoriesAndProducts()
        {
            List<Classes.CategoryClass> listCategory = new List<Classes.CategoryClass>();
            using (TEST_DOOEntities db = new TEST_DOOEntities())
            {
                listCategory = (from d in db.Categories
                                select new Classes.CategoryClass
                                {

                                    Id = d.categoryid,
                                    Name = d.categoryname

                                }).ToList();
            }
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        
        }
        private void ProductListShow()
        {
            try
            {

                List<Classes.ProductClass> listProduct = new List<Classes.ProductClass>();
                int idCat = (int)cbCategory.SelectedValue;
                using (TEST_DOOEntities db = new TEST_DOOEntities())
                {
                    listProduct = (from d in db.Products
                                   where d.categoryid == idCat
                                   select new Classes.ProductClass
                                   {
                                       Id = d.productid,
                                       Price = d.unitprice,
                                       Name = d.productname,

                                   }).ToList();
                    cbProduct.DataSource = listProduct;
                    cbProduct.DisplayMember = "Name";
                    cbProduct.ValueMember = "Price";
                    // cbProduct.ValueMember = "Id";
                    
                }

            }
            catch (InvalidCastException ex)
            {
            }
        }


        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductListShow();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckIfAvailable();
            Create();


        }

        DataTable dt = new DataTable();
        DataRow dr;
        int num, productid;
        decimal price;
        short qty;
        decimal discount;
        
        private void Create()
        {
            string txt = cbProduct.GetItemText(cbProduct.SelectedItem);

            var productId = (from t in db.Products
                             where t.productname == txt
                             select t).FirstOrDefault();
            num = Convert.ToInt32(txtOrderID.Text);
            productid = productId.productid;
            price = productId.unitprice;
            qty = Convert.ToInt16(txtQty.Text);
            dr = dt.NewRow();
            dr["OrderId"] = txtOrderID.Text;
            dr["ProductId"] = productid.ToString();
            dr["UnitPrice"] = price.ToString();
            dr["Qty"] = qty.ToString();
            discount = decimal.Parse(txtDiscount.Text);
            dr["Discount"] = discount.ToString();
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            Clear();


        }
        private void CreateProduct()
        {
           
            string txt = cbProduct.GetItemText(cbProduct.SelectedItem);
            var productId = (from t in db.Products
                             where t.productname == txt
                             select t).FirstOrDefault();
            num = Convert.ToInt32(txtOrderID.Text);
            productid = productId.productid;
            price = productId.unitprice;
            qty = Convert.ToInt16(txtQty.Text);
            try
            {
                discount = decimal.Parse(txtDiscount.Text);
                if (discount > 99)
                {
                    MessageBox.Show("Discount can't be bigger than 99");
                    Clear();
                }
                else if (discount < 0)
                {
                    MessageBox.Show("Discount can't be less than 0");
                }
                else if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                    discount = 0;
                }
                else
                {
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
            Clear();
        }
        private void CheckIfAvailable()
        {
            int qty = 0;
            int available = int.Parse(txtavbitm.Text);
            try
            {
                qty = int.Parse(txtQty.Text);
                if (qty <= 0)
                {
                    throw new Exception("Quantity can not be less than 1");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            
            if (available < qty)
            {
                MessageBox.Show("Quantity unavailable");
            }
            
        }

        private void cbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int d = 0;
            txtPrice.Text = cbProduct.GetItemText(cbProduct.SelectedValue);
            string txt = cbProduct.GetItemText(cbProduct.SelectedItem);
            // MessageBox.Show(txt);
            var product = (from t in db.Products
                          where t.productname == txt
                          select t.stock).FirstOrDefault();
            //MessageBox.Show(product.ToString());
            txtavbitm.Text = product.ToString();
            

            
            
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                OrderDetail od = new OrderDetail();

                od.orderid = Convert.ToInt32(dr.Cells["OrderId"].Value.ToString());
                od.productid = Convert.ToInt32(dr.Cells["ProductId"].Value);
                od.unitprice = Convert.ToDecimal(dr.Cells["UnitPrice"].Value);
                od.qty = Convert.ToInt16(dr.Cells["Qty"].Value);
                od.discount = Convert.ToDecimal(dr.Cells["Discount"].Value.ToString());
                db.OrderDetails.Add(od);
                db.SaveChanges();
            }
            MessageBox.Show("Successfully added.");
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            SalesEmployee_MainPage page = new SalesEmployee_MainPage();
            this.Hide();
            page.Show();
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            txtQty.Text = "";
        }
    }
}
