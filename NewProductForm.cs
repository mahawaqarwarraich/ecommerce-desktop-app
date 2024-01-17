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
    public partial class NewProductForm : Form
    {
        public bool IsPriceEmpty;
        public bool IsQtyEmpty;
        public static bool IsNewProduct = false;
        public  Product CurrentProduct {  get; set; }
        public static List<Product> Products = new List<Product>();
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            // populate combo box with available categores
            FromDataToGUI();
          
            

        }

        public void PopulateCmbCategory()
        {
            List<Category> categoires = CategoryDBHelper.GetAllCategories();
            cmbCategory.Items.Add("Select an item...");
            foreach (var category in categoires)
            {
                cmbCategory.Items.Add(category.Name);
            }
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           

           
            FromGUIToData(); 

            if (NewProductForm.IsNewProduct == true)
            {
                
                if (!string.IsNullOrEmpty(CurrentProduct.Name) && CurrentProduct.EPrice > 0 && CurrentProduct.EQty > 0 && CurrentProduct.CategoryId > 0) {
                    // Add in DB
                    ProductDBHelper.AddNewProduct(CurrentProduct);

                    // Add in products list
                    Products.Add(CurrentProduct);
                    NewProductForm.IsNewProduct = false;
                    DialogResult = DialogResult.OK;
                    
                    this.Close();


                   
                }
               

            }
            else
            {
                // update functionality
                if (!string.IsNullOrEmpty(CurrentProduct.Name) && !IsPriceEmpty && !IsQtyEmpty && CurrentProduct.CategoryId > 0)
                {
                    // Add in DB
                    ProductDBHelper.UpdateProduct(CurrentProduct);

                    
                  
                    DialogResult = DialogResult.OK;
                    this.Close();



                }

            }
        }

      
        // Populating the new product form
        public void FromDataToGUI()
        {
            txtId.Text = CurrentProduct.Id.ToString();
            txtName.Text = CurrentProduct.Name;
            txtPrice.Text = CurrentProduct.EPrice.ToString();
            txtDesc.Text = CurrentProduct.Description;
            txtQty.Text = CurrentProduct.EQty.ToString();



            cmbCategory.SelectedIndex = 0;
        }

        public void FromGUIToData()
        {
            CurrentProduct.Id = Int32.Parse(txtId.Text);
            CurrentProduct.Name = txtName.Text;

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                CurrentProduct.EPrice = 0;
                IsPriceEmpty = true;
            }
            else
            {
                CurrentProduct.EPrice = double.Parse(txtPrice.Text);
                IsPriceEmpty = false;
            }

            if (string.IsNullOrEmpty(txtQty.Text))
            {
                CurrentProduct.EQty = 0;
                IsQtyEmpty = true;
            }
            else
            {
                CurrentProduct.EQty = Int32.Parse(txtQty.Text);
                IsQtyEmpty = false;
            }



            CurrentProduct.Description = txtDesc.Text;

            List<int> catIds = CategoryDBHelper.GetCatIds();
            if (cmbCategory.SelectedIndex  != 0) {
                CurrentProduct.CategoryId = catIds[cmbCategory.SelectedIndex - 1];
            }
            
           
        }

     
    }
}
