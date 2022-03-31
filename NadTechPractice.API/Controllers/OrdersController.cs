using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Contracts.Services;
using NadTechPractice.Utilities;
using NadTechPractice.Utilities.DTOs;

using System;
using System.Threading.Tasks;

namespace NadTechPractice.API.Controllers
{
    [Route("api/customers/{customerId}/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderForCustomer(long customerId, OrderToAddDto model)
        {
            if (!ModelState.IsValid)
                return ServiceResponse.BadRequest(ModelState);

            return await _orderService.AddOrderAsync(customerId, model);
        }

        [HttpGet("{orderId}", Name = nameof(GetOrderById))]
        public async Task<IActionResult> GetOrderById(long customerId, Guid orderId)
        {
            return await _orderService.GetOrderByIdAsync(customerId, orderId);
        }

        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteOrder(long customerId, Guid orderId)
        {
            return await _orderService.DeleteOrderAync(customerId, orderId);
        }
    }
}
