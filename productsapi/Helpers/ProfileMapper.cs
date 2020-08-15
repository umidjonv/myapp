using AutoMapper;
using productsapi.DTO;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Security.Cryptography.X509Certificates;

namespace productsapi.Helpers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Category, CategoryReadDTO>()
                .ForMember(d => d.parentName, opt => opt.MapFrom(src => src.parent.name));

            CreateMap<CategoryWriteDTO, Category>();
            //.ForMember(d => d.parentName, opt => opt.MapFrom(src => src.parent.name));

            CreateMap<Product, ProductReadDTO>()
               .ForMember(d => d.categoryName, opt => opt.MapFrom(src => src.category.name));

            CreateMap<ProductWriteDTO , Product>()
               .ForMember(d => d.category, opt => opt.MapFrom(src => src.category));
        }
    }
}
