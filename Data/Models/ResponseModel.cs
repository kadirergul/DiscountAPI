﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ResponseModel : BaseModel
    {
        public Invoice Invoice { get; set; }
        public string Message  { get; set; }
    }
}
