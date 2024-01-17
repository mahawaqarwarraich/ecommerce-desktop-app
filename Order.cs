using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ecommerce_App
{
    internal class Order
    {
        // Properties
      
        public int Id {  get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
       
        public string Payment { get; set; }

        public string Buyer { get; set; }


        // Contructor
        public Order()
        {
            Status = "Pending";
        }



    }
}
