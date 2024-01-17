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
    public partial class NewCategoryForm : Form
    {
        public static bool IsNewCategory { get; set; }
        public  Category CurrentCategory { get; set; }

        public static List<Category> Categories { get; set; }


        public NewCategoryForm()
        {
            InitializeComponent();
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            FromGUIToData();

            if (NewCategoryForm.IsNewCategory)
            {
                if (!string.IsNullOrEmpty(CurrentCategory.Name) && CurrentCategory.Id > 0)
                {
                    // Add in DB
                    CategoryDBHelper.AddNewCategory(CurrentCategory);

                    // Add in categories list
                    Categories.Add(CurrentCategory);
                    NewCategoryForm.IsNewCategory = false;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                // Update functionality
                if (!string.IsNullOrEmpty(CurrentCategory.Name) && CurrentCategory.Id > 0)
                {
                    // Update in DB
                    CategoryDBHelper.UpdateCategory(CurrentCategory);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FromGUIToData()
        {
            CurrentCategory.Id = Int32.Parse(txtId.Text);
            CurrentCategory.Name = txtName.Text;

        }

       

        public void FromDataToGUI()
        {
            txtId.Text = CurrentCategory.Id.ToString();
            txtName.Text = CurrentCategory.Name;
           
            
        }

        private void NewCategoryForm_Load(object sender, EventArgs e)
        {
            Categories = new List<Category>();
            Categories = CategoryDBHelper.GetAllCategories();

        }
    }
}
