using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App
{
    public class Category
    {
        public int Id { get; set; }

        private string EName { get; set; }
        public string Name
        {
            get
            {
                return EName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    EName = value;
                    System.Windows.Forms.MessageBox.Show("Name cannot be empty");
                } else
                {
                    EName = value;
                }
            }

        }


       
        public Category()
        {
            Name = "No Name";

        }

        public Category(string name)
        {
            Name = name;

        }
    }
}
