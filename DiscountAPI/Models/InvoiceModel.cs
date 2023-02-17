using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class InvoiceModel : BaseModel
    {
        public string AppliedDiscountDescription { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalAmount { get; set; }
        public List<string> ProductsCategory { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
