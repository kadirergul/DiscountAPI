using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class EmployeeDiscountRequirementRule : IDiscountRequirementRule
    {
        public async Task<(bool isValid, string errorMessage)> CheckDiscount(Customer customer)
        {
            return (true, "error");
        }
    }
}
