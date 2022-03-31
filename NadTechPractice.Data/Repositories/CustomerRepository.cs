using Microsoft.EntityFrameworkCore;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Entities.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadTechPractice.Data.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(NadTechPracticeContext ctx) : base(ctx) { }
        public void AddCustomer(Customer customrer)
        {
            Create(customrer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Delete(customer);
        }

        public async Task<Customer> GetCustomerIdAsync(long customerId, bool trackChanges = false)
        {
            return await FindByCondition(x => x.CustomerId == customerId, trackChanges).FirstOrDefaultAsync();
        }

        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }

        public async Task<Customer> GetCustomerWithOrdersAsync(long customerId, bool trackChanges = false)
        {
            return await FindAll(trackChanges)
                .Include(c => c.Address)
                .Include(c => c.Orders)
                .Where(c => c.CustomerId == customerId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomers(bool trackChanges = false) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<IEnumerable<Customer>> SearchByName(string name, bool trackChanges = false)
        {
            return await FindByCondition(c => c.Name.ToLower().Contains(name.ToLower()), trackChanges).ToListAsync();
        }
    }
}
