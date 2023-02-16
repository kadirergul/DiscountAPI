using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public string AppliedDiscountDescription { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalAmount { get; set; }
        public Customer Customer { get; set; }
    }
}
