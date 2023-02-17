using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IDiscountRequirementRule
    {
        Task<(bool isValid, string errorMessage)> CheckDiscount(Customer invoice);
    }
}
