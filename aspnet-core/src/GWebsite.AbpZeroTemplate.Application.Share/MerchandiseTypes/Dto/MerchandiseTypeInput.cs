﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.MerchandiseTypes.Dto
{
    public class MerchandiseTypeInput: Entity<int>
    {
        public string TypeID { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public string Note { get; set; }
    }
}
