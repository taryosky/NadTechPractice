
using NadTechPractice.Contracts.Repositories;

using System.Threading.Tasks;

namespace NadTechPractice.Data.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly NadTechPracticeContext _ctx;
        private ICustomerRepository _customerRepository;
        private IOrderRepository _orderRepository;
        public RepositoryManager(NadTechPracticeContext ctx)
        {
            _ctx = ctx;
        }
        public ICustomerRepository Customers
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_ctx);
                return _customerRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new OrderRepository(_ctx);
                return _orderRepository;
            }
        }

        public async Task<bool> Save()
        {
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
