using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class RequestModel : BaseModel
    {
        public InvoiceModel Invoice { get; set; }
    }
}
