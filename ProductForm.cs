using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ecommerce_App
{
    public partial class ProductForm : Form
    {

       

        public int SelectedId {  get; set; }




        public ProductForm()
        {
            InitializeComponent();

        }
        public void PopulateDGV()
        {
            

            var products = ProductDBHelper.GetAllProducts();


            if (products != null)
            {
                dgvProducts.DataSource = null;
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.DataSource = products;
                
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[0];
                SelectedId = (int)selectedRow.Cells[0].Value;
            }
            PopulateDGV();
        }

       

        private void UpdateDataGridView()
        {
            var products = ProductDBHelper.GetAllProducts();


            if (products != null)
            {

                dgvProducts.DataSource = null;
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.DataSource = products;
            }
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            NewProductForm newProductForm = new NewProductForm();
            var products = ProductDBHelper.GetAllProducts();
            if (products != null)
            {              
                newProductForm.CurrentProduct = products.Find(product => product.Id == SelectedId);
            }

            newProductForm.PopulateCmbCategory();

            // Populate the form with the product to be updated
            newProductForm.FromDataToGUI();



            if (newProductForm.ShowDialog() == DialogResult.OK)
            {

                UpdateDataGridView();
                newProductForm.Close();

            }
        }

       
        private void dgvProducts_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            SelectedId = (int)row.Cells[0].Value;

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var products = ProductDBHelper.GetAllProducts();
            Product productToDlt = products.Find(product => product.Id == SelectedId);
            ProductDBHelper.DeleteProduct(productToDlt);
            UpdateDataGridView();


          
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            NewProductForm.IsNewProduct = true;
            NewProductForm newProductForm = new NewProductForm();

            newProductForm.CurrentProduct = new Product();
            newProductForm.CurrentProduct.Id = ProductDBHelper.GetMaxId();

            newProductForm.PopulateCmbCategory();
            newProductForm.FromDataToGUI();

            if (newProductForm.ShowDialog() == DialogResult.OK)
            {
                PopulateDGV();
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please first enter product's name in the search bar!");
            }
            else
            {
                var products = ProductDBHelper.GetAllProducts();
                var myProducts = products.FindAll(p => p.Name == productName);
                dgvProducts.DataSource = myProducts;

            }

        }
    }
}
