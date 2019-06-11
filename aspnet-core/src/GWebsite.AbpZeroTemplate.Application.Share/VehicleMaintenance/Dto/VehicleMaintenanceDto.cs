﻿using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.VehicleMaintenances.Dto
{
    /// <summary>
    /// <model cref="VehicleMaintenance"></model>
    /// </summary>
    public class VehicleMaintenanceDto : Entity<int>
    {
        public string PlateNumber { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime NextMaintenanceDate { get; set; }
        public int MoneyAmount { get; set; }
        public int NumberMaintenanceTimes { get; set; }
        public string MaintenanceCategories { get; set; }
        public string Note { get; set; }
        public string MaintenanceUnit { get; set; }

    }
}