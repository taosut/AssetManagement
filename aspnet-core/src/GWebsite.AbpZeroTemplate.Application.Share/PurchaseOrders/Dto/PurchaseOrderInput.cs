﻿using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Application.Share.Contracts.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Providers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.PurchasePaymentHistories.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.PurchaseProductDetails.Dto;
using GWebsite.AbpZeroTemplate.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.PurchaseOrders.Dto
{
    public class PurchaseOrderInput : Entity<int>
    {
        public PurchaseOrderInput()
        {
            PurchasePaymentHistories = new List<PurchasePaymentHistoryInput>();
            PurchaseProductDetails = new List<PurchaseProductDetailInput>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public Area? Area { get; set; }
        public int? UnitId { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        [StringLength(256)]
        public string TransactionOfficeName { get; set; }
        public bool? IsIndependentUnit { get; set; }

        [StringLength(50)]
        public string ReportCode { get; set; }

        public DateTime? ReportRecievedDate { get; set; }
        public DateTime? ReportApprovalDate { get; set; }

        public string AttachmentFile { get; set; }

        public decimal? TotalPrice { get; set; }
        public decimal? TotalMoneyPaid { get; set; }
        public bool IsApproval { get; set; }
        public bool IsInProject { get; set; }
        //FK
        public int? ContractId { get; set; }
        public ContractInput Contract { get; set; }
        //public ContractInput Contract { get; set; }
        public int? ProviderId { get; set; }
        public ProviderInput Provider { get; set; }
        //public ProviderInput Provider { get; set; }
        public ICollection<PurchasePaymentHistoryInput> PurchasePaymentHistories { get; set; }
        public ICollection<PurchaseProductDetailInput> PurchaseProductDetails { get; set; }
    }
}
