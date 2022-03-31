using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Contracts.Services;
using NadTechPractice.Entities.Models;
using NadTechPractice.Utilities;
using NadTechPractice.Utilities.DTOs;

using System;
using System.Threading.Tasks;

namespace NadTechPractice.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ObjectResult> AddOrderAsync(long customerId, OrderToAddDto model)
        {
            var customer = await _repository.Customers.GetCustomerIdAsync(customerId, trackChanges: true);
            if (customer == null)
                return ServiceResponse.NotFound("Customer not found");

            var order = _mapper.Map<Order>(model);
            order.CustomerId = customer.CustomerId;
            _repository.Orders.AddOrder(order);

            await _repository.Save();

            var orderToReturn = _mapper.Map<OrderDto>(order);

            return ServiceResponse.Created("GetOrderById", new { customerId = customer.CustomerId, orderId = order.OrderId }, orderToReturn);
        }

        public async Task<ObjectResult> GetOrderByIdAsync(long customerId, Guid orderId)
        {
            var order = await _repository.Orders.GetOrderIdAsync(customerId, orderId);
            if (order == null)
                return ServiceResponse.NotFound("Order not found");

            var orderToReturn = _mapper.Map<OrderDto>(order);
            return ServiceResponse.Ok(orderToReturn);
        }

        public async Task<ObjectResult> DeleteOrderAync(long customerId, Guid orderId)
        {
            var order = await _repository.Orders.GetOrderIdAsync(customerId, orderId);
            if (order == null)
                return ServiceResponse.NotFound("Order not found");

            _repository.Orders.DeleteOrder(order);
            await _repository.Save();

            var orderToReturn = _mapper.Map<OrderDto>(order);
            return ServiceResponse.Ok(orderToReturn);
        }
    }
}
