using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.Contracts;
using GWebsite.AbpZeroTemplate.Application.Share.Contracts.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ContractDetails.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ContractPayments.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Merchandises;
using GWebsite.AbpZeroTemplate.Application.Share.Merchandises.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MerchandiseTypes.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Vendors.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.VendorTypes.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Projects.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using GWebsite.AbpZeroTemplate.Application.Share.AssignmentTables.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Bids.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Bidders.Dto;

namespace GWebsite.AbpZeroTemplate.Applications
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<MenuClient, MenuClientDto>();
            configuration.CreateMap<MenuClient, MenuClientListDto>();
            configuration.CreateMap<CreateMenuClientInput, MenuClient>();
            configuration.CreateMap<UpdateMenuClientInput, MenuClient>();

            // DemoModel
            configuration.CreateMap<DemoModel, DemoModelDto>();
            configuration.CreateMap<DemoModelInput, DemoModel>();
            configuration.CreateMap<DemoModel, DemoModelInput>();
            configuration.CreateMap<DemoModel, DemoModelForViewDto>();

            // Customer
            configuration.CreateMap<Customer, CustomerDto>();
            configuration.CreateMap<CustomerInput, Customer>();
            configuration.CreateMap<Customer, CustomerInput>();
            configuration.CreateMap<Customer, CustomerForViewDto>();

            // Merchandise
            configuration.CreateMap<Merchandise, MerchandiseDto>();
            configuration.CreateMap<MerchandiseInput, Merchandise>();
            configuration.CreateMap<Merchandise, MerchandiseInput>();
            configuration.CreateMap<Merchandise, MerchandiseForViewDto>();

            // MerchandiseType
            configuration.CreateMap<MerchandiseType, MerchandiseTypeDto>();
            configuration.CreateMap<MerchandiseTypeInput, MerchandiseType>();
            configuration.CreateMap<MerchandiseType, MerchandiseTypeInput>();
            configuration.CreateMap<MerchandiseType, MerchandiseTypeForViewDto>();

            // Vendor            
            configuration.CreateMap<Vendor, VendorDto>();
            configuration.CreateMap<VendorInput, Vendor>();
            configuration.CreateMap<Vendor, VendorInput>();
            configuration.CreateMap<Vendor, VendorForViewDto>();

            // VendorType
            configuration.CreateMap<VendorType, VendorTypeDto>();
            configuration.CreateMap<VendorTypeInput, VendorType>();
            configuration.CreateMap<VendorType, VendorTypeInput>();
            configuration.CreateMap<VendorType, VendorTypeForViewDto>();
          
            //Contract
            configuration.CreateMap<Contract,ContractDto>();
            configuration.CreateMap<ContractInput,Contract>();
            configuration.CreateMap<Contract, ContractInput>();
            configuration.CreateMap<Contract, ContractForViewDto>();

            //ContractDetailDetail
            configuration.CreateMap<ContractDetail, ContractDetailDto>();
            configuration.CreateMap<ContractDetailInput, ContractDetail>();
            configuration.CreateMap<ContractDetail, ContractDetailInput>();

            //ContractPaymentDetail
            configuration.CreateMap<ContractPayment, ContractPaymentDto>();
            configuration.CreateMap<ContractPaymentInput, ContractPayment>();
            configuration.CreateMap<ContractPayment, ContractPaymentInput>();


            //Project
            configuration.CreateMap<Project, ProjectDto>();
            configuration.CreateMap<ProjectInput, Project>();
            configuration.CreateMap<Project, ProjectInput>();
            configuration.CreateMap<Project, ProjectForViewDto>();

            //AssignmentTable
            configuration.CreateMap<AssignmentTable, AssignmentTableDto>();
            configuration.CreateMap<AssignmentTableInput, AssignmentTable>();
            configuration.CreateMap<AssignmentTable, AssignmentTableInput>();
            configuration.CreateMap<AssignmentTable, AssignmentTableForViewDto>();

            //Bid
            configuration.CreateMap<Bid, BidDto>();
            configuration.CreateMap<BidInput, Bid>();
            configuration.CreateMap<Bid, BidInput>();
            configuration.CreateMap<Bid, BidForViewDto>();

            // Bidder
            configuration.CreateMap<Bidder, BidderDto>();
            configuration.CreateMap<BidderInput, Bidder>();
            configuration.CreateMap<Bidder, BidderInput>();
            configuration.CreateMap<Bidder, BidderForViewDto>();
        }
    }
}