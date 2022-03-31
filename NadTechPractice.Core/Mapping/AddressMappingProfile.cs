using AutoMapper;

using NadTechPractice.Entities.Models;
using NadTechPractice.Utilities.DTOs;

namespace NadTechPractice.Core.Mapping
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<AddressToAddDto, Address>();
            CreateMap<Address, AddressDto>();
        }
    }
}
