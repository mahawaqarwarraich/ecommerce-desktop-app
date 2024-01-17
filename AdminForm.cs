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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void mngProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Fitting products form
            ProductForm productForm = new ProductForm();

            productForm.ControlBox = false;        
            productForm.FormBorderStyle = FormBorderStyle.None;

            productForm.TopLevel = false;
            productForm.Dock = DockStyle.Fill;

            
            panel2.Controls.Clear();  
            panel2.Controls.Add(productForm);
            
            // Populate the products form with products
            productForm.PopulateDGV();
            productForm.Show();
        }

        private void mngCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.ControlBox = false;
            categoryForm.FormBorderStyle = FormBorderStyle.None;

            categoryForm.TopLevel = false;
            categoryForm.Dock = DockStyle.Fill;


            panel2.Controls.Clear();
            panel2.Controls.Add(categoryForm);


            categoryForm.Show();
        }

        private void mngOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrderForm orderForm = new OrderForm();

            orderForm.ControlBox = false;
            orderForm.FormBorderStyle = FormBorderStyle.None;

            orderForm.TopLevel = false;
            orderForm.Dock = DockStyle.Fill;


            panel2.Controls.Clear();
            panel2.Controls.Add(orderForm);

            orderForm.PopulateDGV();
            orderForm.Show();
        }

       

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Fitting products form
            ProductForm productForm = new ProductForm();

            productForm.ControlBox = false;
            productForm.FormBorderStyle = FormBorderStyle.None;

            productForm.TopLevel = false;
            productForm.Dock = DockStyle.Fill;


            panel2.Controls.Clear();
            panel2.Controls.Add(productForm);

            // Populate the products form with products
            productForm.PopulateDGV();
            productForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
