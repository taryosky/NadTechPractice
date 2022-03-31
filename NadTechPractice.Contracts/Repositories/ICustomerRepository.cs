using NadTechPractice.Entities.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NadTechPractice.Contracts.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerIdAsync(long customerId, bool trackChanges = false);
        Task<Customer> GetCustomerWithOrdersAsync(long customerId, bool trackChanges = false);
        Task<IEnumerable<Customer>> GetCustomers(bool trackChanges = false);
        Task<IEnumerable<Customer>> SearchByName(string name, bool trackChanges = false);
        void AddCustomer(Customer customrer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
