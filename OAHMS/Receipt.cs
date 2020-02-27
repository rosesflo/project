using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OAHMS
{
    public class Receipt
    {   
        
        public int InvoiceNumber { get; set; }
        public string ResidentXName { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get { return string.Format("{0}$", Price * Quantity); } }
    
        

    }
}
