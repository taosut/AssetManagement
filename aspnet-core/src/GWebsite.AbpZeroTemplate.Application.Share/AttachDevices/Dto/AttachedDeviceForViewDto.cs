﻿using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.AttachedDevices.Dto
{
    /// <summary>
    /// <model cref="AttachedDevice"></model>
    /// </summary>
    public class AttachedDeviceForViewDto
    {
        public string PlateNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Explain { get; set; }
    }
}