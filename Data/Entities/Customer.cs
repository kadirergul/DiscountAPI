using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAffiliate { get; set; }
        public bool IsEmployee { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
