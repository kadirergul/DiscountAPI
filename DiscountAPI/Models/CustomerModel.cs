using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class CustomerModel : BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool IsCompanyEmployee { get; set; } = false;
        public bool IsInLoyaltyProgram { get; set; } = false;
        public bool IsOverTwoYear { get; set; } = false;

    }
}
