using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Northwind;
using KendoJSGrid.Models;

namespace KendoJSGrid.AutoMapperConfig
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<SupplierViewModel, Supplier>();
            CreateMap<CategoryViewModel, Category>().ForMember(x => x.Picture, opt => opt.Ignore());
            CreateMap<ProductViewModel, Product>();
        }

    }
}