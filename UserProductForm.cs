using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App
{
    public partial class UserProductForm : Form
    {
        public int SelectedId {  get; set; }
        public static double Total { get; set; }
        public List<Product> Products { get; set; }
        public UserProductForm()
        {
            InitializeComponent();
        }

        private void UserProductForm_Load(object sender, EventArgs e)
        {
            
          
            if (dgvProducts.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[0];
                SelectedId = (int)selectedRow.Cells[0].Value;
            }
           
            PopulateDGV();
        }

        public void PopulateDGV()
        {


            Products = new List<Product>();
            Products = ProductDBHelper.GetAllProducts();

            if (Products != null)
            {
                dgvProducts.DataSource = null;
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.DataSource = Products;

            }
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            SelectedId = (int)row.Cells[0].Value;
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
           

            if (SelectedId >  0)
            {
                int itemsNum = Convert.ToInt32(items.Text);
                itemsNum += 1;
                items.Text = itemsNum.ToString();
                Product product = Products.Find(p => p.Id == SelectedId);
                Total += product.EPrice;
            } else
            {
                MessageBox.Show("Please select an item first!");
            }
           

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string productName = txtProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please first enter product's name in the search bar!");
            } else
            {
                var products = Products.FindAll(p => p.Name == productName);
                dgvProducts.DataSource = products;

            }

        }
    }
}
