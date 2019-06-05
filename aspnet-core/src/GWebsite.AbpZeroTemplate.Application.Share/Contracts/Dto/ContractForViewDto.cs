﻿using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Application.Share.Bids.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ProductContracts.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Providers.Dto;
using GWebsite.AbpZeroTemplate.Core.Models.Enums;
using GWebsite.AbpZeroTemplate.Core.Models.Enums.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Contracts.Dto
{
    public class ContractForViewDto : Entity<int>
    {
        public ContractForViewDto()
        {
            ProductContracts = new List<ProductContractForViewDto>();
        }
        public string Code { get; set; }

        public string Name { get; set; }
        //[Column(TypeName = "varchar(50)")]
        //public string BidCode { get; set; }
        //[Column(TypeName = "varchar(50)")]
        //public string ProviderCode { get; set; }
        public DateTime? ContractCreatedDate { get; set; }
        public Status Status { get; set; }

        public string Note { get; set; }
        //
        //Contract Guarantee
        public ContractGuaranteeForm ContractGuaranteeForm { get; set; }

        public string ContractCertificateNumber { get; set; }
        public DateTime? ContractCertificateEndDate { get; set; }
        public decimal? ContractCertificatePrice { get; set; }
        public decimal? ContractCertificatePricePercent { get; set; }

        public string ContractGuaranteeBankName { get; set; }
        public string ContractGuaranteeAttachmentFile { get; set; }

        //Warranty Guarantee
        public GuaranteeForm WarrantyGuaranteeForm { get; set; }

        public string WarrantyCertificateNumber { get; set; }
        public DateTime? WarrantyCertificateEndDate { get; set; }
        public decimal? WarrantyCertificatePrice { get; set; }
        public decimal? WarrantyCertificatePricePercent { get; set; }

        public string WarrantyGuaranteeBankName { get; set; }
        public string WarrantyGuaranteeAttachmentFile { get; set; }
        //
        //Price
        public decimal? TotalProductPrice { get; set; }
        public decimal? TotalPrice { get; set; }

        //FK
        public int? BidId { get; set; }
        public BidDto Bid { get; set; }
        public int? ProviderId { get; set; }
        public ProviderDto Provider { get; set; }
        public virtual ICollection<ProductContractForViewDto> ProductContracts { get; set; }
    }
}
