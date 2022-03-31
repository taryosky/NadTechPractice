using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Contracts.Services;
using NadTechPractice.Utilities;
using NadTechPractice.Utilities.DTOs;

using System.Threading.Tasks;

namespace NadTechPractice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerToAddDto model)
        {
            if (!ModelState.IsValid)
            {
                return ServiceResponse.BadRequest(ModelState);
            }

            if (model.Address == null || model.Address.Count < 1)
            {
                ModelState.AddModelError("Address", "Customer must have at least one address");
                return ServiceResponse.BadRequest(ModelState);
            }

            return await _customerService.AddCustomerAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerAsync(long id, CustomerToUpdateDto model)
        {
            if (!ModelState.IsValid)
            {
                return ServiceResponse.BadRequest(ModelState);
            }

            return await _customerService.UpdateCustomerAsync(id, model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(long id)
        {
            return await _customerService.DeleteCustomerAsync(id);
        }

        [HttpGet("{id:long}", Name = nameof(GetCustomerById))]
        public async Task<IActionResult> GetCustomerById([FromRoute] long id)
        {
            return await _customerService.GetCustomerWIthOrdersAsync(id);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
            => await _customerService.GetCustomersAsync();

        [HttpGet("search")]
        public async Task<IActionResult> GetCustomersByName([FromQuery]string query)
        {
            return await _customerService.GetCustomersByName(query);
        }
    }
}
