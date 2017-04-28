using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Northwind;
using KendoJSGrid.Models;

namespace KendoJSGrid.AutoMapperConfig
{
    public class DomainToViewModelMappingProfile : Profile
    {
       
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Supplier, SupplierViewModel>();
            CreateMap<Category, CategoryViewModel>().ForMember(x => x.Picture, opt => opt.Ignore());
            CreateMap<Product, ProductViewModel>();
        }
    }
}