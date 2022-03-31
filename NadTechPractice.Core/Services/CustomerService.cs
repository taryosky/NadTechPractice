using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Contracts.Services;
using NadTechPractice.Entities.Models;
using NadTechPractice.Utilities;
using NadTechPractice.Utilities.DTOs;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadTechPractice.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ObjectResult> AddCustomerAsync(CustomerToAddDto model)
        {
            var customer = _mapper.Map<Customer>(model);
            _repository.Customers.AddCustomer(customer);

            await _repository.Save();

            var customerToReturn = _mapper.Map<CustomerDto>(customer);
            return ServiceResponse.Created("GetCustomerById", new { id = customerToReturn.CustomerId }, customerToReturn);
        }

        public async Task<ObjectResult> GetCustomerWIthOrdersAsync(long customerId)
        {
            var customer = await _repository.Customers.GetCustomerWithOrdersAsync(customerId);
            if (customer == null)
            {
                return ServiceResponse.NotFound("Customer not found");
            }

            var customerToReturn = _mapper.Map<CustomerWithOrdersDto>(customer);
            return ServiceResponse.Ok(customerToReturn);
        }

        public async Task<IActionResult> UpdateCustomerAsync(long customerId, CustomerToUpdateDto model)
        {
            var customer = await _repository.Customers.GetCustomerIdAsync(customerId, trackChanges: true);
            if (customer == null)
                return ServiceResponse.NotFound("Customer was not found");

            _mapper.Map(model, customer);
            _repository.Customers.UpdateCustomer(customer);

            await _repository.Save();

            return ServiceResponse.NoContent();
        }

        public async Task<IActionResult> DeleteCustomerAsync(long customerId)
        {
            var customer = await _repository.Customers.GetCustomerIdAsync(customerId, trackChanges: true);
            if (customer == null)
                return ServiceResponse.NotFound("Customer not found");

            _repository.Customers.DeleteCustomer(customer);
            await _repository.Save();

            var customerToReturn = _mapper.Map<CustomerDto>(customer);
            return ServiceResponse.Ok(customerToReturn);
        }

        public async Task<ObjectResult> GetCustomersAsync()
        {
            var customers = await _repository.Customers.GetCustomers();
            var customersToReturn = _mapper.Map<IEnumerable<CustomerMinInfoDto>>(customers);
            return ServiceResponse.Ok(customersToReturn);
        }

        public async Task<ObjectResult> GetCustomersByName(string name)
        {
            var customers = await _repository.Customers.SearchByName(name);
            var customersToReturn = _mapper.Map<IEnumerable<CustomerMinInfoDto>>(customers);
            return ServiceResponse.Ok(customersToReturn);
        }
    }
}
