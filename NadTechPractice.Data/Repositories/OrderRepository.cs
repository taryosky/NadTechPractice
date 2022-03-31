using Microsoft.EntityFrameworkCore;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Entities.Models;

using System;
using System.Threading.Tasks;

namespace NadTechPractice.Data.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(NadTechPracticeContext ctx) : base(ctx)
        {

        }
        public void AddOrder(Order order)
        {
            Create(order);
        }

        public void DeleteOrder(Order order)
        {
            Delete(order);
        }

        public async Task<Order> GetOrderIdAsync(long customerId, Guid orderId, bool trackChanges = false)
        {
            return await FindByCondition(o => o.CustomerId == customerId && o.OrderId.Equals(orderId), trackChanges).FirstOrDefaultAsync();
        }

        public void UpdateOrder(Order order)
        {
            Update(order);
        }
    }
}
