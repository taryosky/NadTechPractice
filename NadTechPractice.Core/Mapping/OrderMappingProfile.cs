using AutoMapper;

using NadTechPractice.Entities.Models;
using NadTechPractice.Utilities.DTOs;

namespace NadTechPractice.Core.Mapping
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderToAddDto, Order>();
            CreateMap<Order, OrderDto>()
                .ForMember(o => o.OrderDate, opt => opt.MapFrom(ord => ord.DateCreated));
        }
    }
}
