using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Discount : BaseEntity
    {
        public string Name { get; set; }
        public DiscountType Type { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
