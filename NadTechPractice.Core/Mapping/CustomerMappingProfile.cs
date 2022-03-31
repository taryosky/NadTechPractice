using AutoMapper;

using NadTechPractice.Entities.Models;
using NadTechPractice.Utilities.DTOs;

namespace NadTechPractice.Core.Mapping
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerToAddDto, Customer>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerToUpdateDto, Customer>();
            CreateMap<Customer, CustomerWithOrdersDto>();
            CreateMap<Customer, CustomerMinInfoDto>();
        }
    }
}
