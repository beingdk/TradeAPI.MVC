﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data.Model
{
    public class CompanyEntity
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Inactive { get; set; }
        public string UserID { get; set; }
    }
}
