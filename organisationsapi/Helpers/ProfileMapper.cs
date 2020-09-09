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
            CreateMap<Bank, BankReadDTO>();

            CreateMap<BankWriteDTO, Bank>();

            CreateMap<Organisation, OrgReadDTO>()
                .ForMember(d => d.bankName, opt => opt.MapFrom(src => src.bankDetails.name));

            CreateMap<OrgWriteDTO, Organisation>()
                .ForMember(d => d.bankDetails, opt => opt.MapFrom(src => src.bankDetails));
        }
    }
}
