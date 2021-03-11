using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerAgenda.Business.Services
{
    public class PhoneContactService : IPhoneContactService
    {
        private readonly IPhoneContactRepository _phoneContactRepository;
        private readonly ICustomerRepository _customerRepository;

        public PhoneContactService(IPhoneContactRepository phoneContactRepository, ICustomerRepository customerRepository)
        {
            _phoneContactRepository = phoneContactRepository;
            _customerRepository = customerRepository;
        }

        public IEnumerable<PhoneContact> GetAll(Guid customerId, Guid hostelId)
        {
            var phoneContacts = _phoneContactRepository.List().Where(a => a.CustomerId == customerId);

            var customersIds = _customerRepository.List().Where(a => a.HostelKey == hostelId).Select(a => a.Id);
            var hostelPhoneContacts = _phoneContactRepository.List().Where(a => customersIds.Contains(a.CustomerId) && a.Type == PhoneContactType.Local);

            return phoneContacts.Concat(hostelPhoneContacts.Except(phoneContacts));
        }

        public void Dispose()
        {
            _phoneContactRepository?.Dispose();
        }
    }
}
