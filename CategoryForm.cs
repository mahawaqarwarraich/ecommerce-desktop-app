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
    public partial class CategoryForm : Form
    {

        public int SelectedId {  get; set; }
       
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (dgvCategories.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategories.Rows[0];
                SelectedId = (int)selectedRow.Cells[0].Value;
            }
            UpdateDGV();


        }

        private void newBtn_Click(object sender, EventArgs e)
        {  
            NewCategoryForm.IsNewCategory = true;
            NewCategoryForm newCategoryForm = new NewCategoryForm();

            
            newCategoryForm.CurrentCategory = new Category();
            newCategoryForm.CurrentCategory.Id = CategoryDBHelper.GetMaxId();

            
            newCategoryForm.FromDataToGUI();


            
            if (newCategoryForm.ShowDialog() == DialogResult.OK)
            {

               UpdateDGV();

            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            NewCategoryForm newCategoryForm = new NewCategoryForm();
            var categories = CategoryDBHelper.GetAllCategories();
            if (categories != null)
            {
                newCategoryForm.CurrentCategory = categories.Find(category => category.Id == SelectedId);
            }

            // Populate the form with the category to be updated
            newCategoryForm.FromDataToGUI();

            if (newCategoryForm.ShowDialog() == DialogResult.OK)
            {
                UpdateDGV();  // You might need to adapt this method based on how you update the DataGridView for categories.
                newCategoryForm.Close();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var categories = CategoryDBHelper.GetAllCategories();
            Category categoryToDlt = categories.Find(category => category.Id == SelectedId);
            CategoryDBHelper.DeleteCategory(categoryToDlt);
            UpdateDGV();  // You might need to adapt this method based on how you update the DataGridView for categories.

        }

        private void UpdateDGV()
        {
            var categories = CategoryDBHelper.GetAllCategories();
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.DataSource = categories;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
            SelectedId = (int)row.Cells[0].Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
