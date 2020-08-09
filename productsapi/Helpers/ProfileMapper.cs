using AutoMapper;
using productsapi.DTO;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Helpers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Category, CategoryReadDTO>()
                .ForMember(d => d.parentName, opt => opt.MapFrom(src => src.parent.name));

            CreateMap<CategoryWriteDTO, Category>();
        }
    }
}
