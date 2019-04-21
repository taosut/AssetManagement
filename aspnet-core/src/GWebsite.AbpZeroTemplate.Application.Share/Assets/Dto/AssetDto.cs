﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWebsite.AbpZeroTemplate.Core.Models;
using Abp.Domain.Entities;
namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    /// <summary>
    /// <model cref="Asset"></model>
    /// </summary>
    public class AssetDto : Entity<int>
    {
        public string nameAsset { get; set; }
        public string mountAsset { get; set; }
        public bool isRentOut { get; set; } 
        public bool valueAsset { get; set; }
    }
}