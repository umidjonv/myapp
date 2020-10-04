using AutoMapper;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using organisationsapi.DTO;
using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Helpers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Bank, BankDTO>().ReverseMap();

            //CreateMap<BankWriteDTO, Bank>();

            CreateMap<Organisation, OrgDTO>().ReverseMap();


            //CreateMap<OrgWriteDTO, Organisation>()
            //    .ForMember(d => d.BankDetails, opt => opt.MapFrom(src => src.BankDetails));
        }
    }
}
