using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;

namespace CustomerAgenda.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int Insert(Customer customer)
        {
            _customerRepository.Insert(customer);
            return _customerRepository.SaveChanges();
        }

        public int Update(Customer customer)
        {
            _customerRepository.Update(customer);
            return _customerRepository.SaveChanges();
        }

        public Customer Read(Guid id)
        {
            return _customerRepository.Read(id);
        }

        public int Delete(Guid id)
        {
            _customerRepository.Delete(id);
            return _customerRepository.SaveChanges();
        }

        public IEnumerable<Customer> List()
        {
            return _customerRepository.List();
        }

        public void Dispose()
        {
            _customerRepository?.Dispose();
        }
    }
}
