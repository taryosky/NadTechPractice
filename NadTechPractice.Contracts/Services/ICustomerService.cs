using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Utilities.DTOs;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NadTechPractice.Contracts.Services
{
    public interface ICustomerService
    {
        Task<ObjectResult> GetCustomersAsync();
        Task<ObjectResult> AddCustomerAsync(CustomerToAddDto model);
        Task<ObjectResult> GetCustomerWIthOrdersAsync(long customerId);
        Task<IActionResult> UpdateCustomerAsync(long customerId, CustomerToUpdateDto model);
        Task<IActionResult> DeleteCustomerAsync(long customerId);
        Task<ObjectResult> GetCustomersByName(string name);
    }
}
