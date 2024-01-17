using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App
{
    public class Product
    {
        public int Id {  get; set; }
        private string EName { get; set; }

        public string Name {
            get { return EName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    EName = value;
                } else
                {
                    EName = "";
                    System.Windows.Forms.MessageBox.Show("Name cannot be empty!");
                }
            }
        
        }
        
        public string Description { get; set; }

        private double Price { get; set; }

        public double EPrice { get { return Price; } set {
                if (value <= 0)
                {
                    
                    System.Windows.Forms.MessageBox.Show("Please enter a valid price greater than 0");
                }
                else
                {
                   
                    Price = value;
                }

            }

        }
        private int Qty { get; set; }

        public int EQty { 
            get { return Qty; } 
            set {

                if (value <= 0)
                {

                    System.Windows.Forms.MessageBox.Show("Please enter a valid quantity greater than zero. Example: 1, 2, 10, etc.");
                }
                else
                {

                    Qty = value;
                }

            }
        }
        public string CategoryName { get; set; }

     
        private int ECategoryId {  get; set; }

        public int CategoryId
        {
            get
            {
                return ECategoryId;
            }

            set
            {
                if (value == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Category cannot be empty!");
                } else
                {
                    ECategoryId = value;
                }
            }
        }

        public int CmbCategoryId { get; set; }



        // Constructor
        public Product()
        {
            Name = "No Name";
            Price = 0;
            Qty = 0;
            Description = "No Description";
            CmbCategoryId = 1;
          
           
        }

    }
}
