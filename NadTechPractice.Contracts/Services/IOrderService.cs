using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Utilities.DTOs;

using System;
using System.Threading.Tasks;

namespace NadTechPractice.Contracts.Services
{
    public interface IOrderService
    {
        Task<ObjectResult> AddOrderAsync(long customerId, OrderToAddDto model);
        Task<ObjectResult> GetOrderByIdAsync(long customerId, Guid orderId);
        Task<ObjectResult> DeleteOrderAync(long customerId, Guid orderId);
    }
}
