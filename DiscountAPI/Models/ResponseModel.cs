using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class ResponseModel : BaseModel
    {
        public InvoiceModel Invoice { get; set; }
        public string Message  { get; set; }
    }
}
