using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerAgenda.Business.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ICustomerRepository _customerRepository;

        public AddressService(IAddressRepository addressRepository, ICustomerRepository customerRepository)
        {
            _addressRepository = addressRepository;
            _customerRepository = customerRepository;
        }

        IEnumerable<Address> IAddressService.GetAll(Guid customerId, Guid hostelId)
        {
            var customerAddress = _addressRepository.List().Where(a => a.CustomerId == customerId);
            
            var customersIds = _customerRepository.List().Where(a => a.HostelKey == hostelId).Select(a => a.Id).ToList();
            var hostelAdsress = _addressRepository.List().Where(a => customersIds.Contains(a.CustomerId));

            return customerAddress.Concat(hostelAdsress.Except(customerAddress));
        }

        public void Dispose()
        {
            _addressRepository?.Dispose();
        }
    }
}
