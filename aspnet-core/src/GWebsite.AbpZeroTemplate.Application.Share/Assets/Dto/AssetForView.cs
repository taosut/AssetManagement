﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
   public class AssetForView : Entity
    {
        public string nameAsset { get; set; }
        public int mountAsset { get; set;  }
    }

}
