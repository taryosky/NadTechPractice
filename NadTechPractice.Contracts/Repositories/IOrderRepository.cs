using NadTechPractice.Entities.Models;

using System;
using System.Threading.Tasks;

namespace NadTechPractice.Contracts.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderIdAsync(long customerId, Guid orderId, bool trackChanges = false);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
