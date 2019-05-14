﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class AsssetRent : FullAuditModel
    {
        public string assetRentID { get; set; }
        public string nameAsset { get; set; }
        public string rentBy { get; set;  }
        public DateTime? dateRent { get; set; }
        public DateTime datePay { get; set; }
        public int numberRent { get; set; }
        public int numberPay { get; set; }

    }
}
