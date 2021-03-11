using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;

namespace CustomerAgenda.Business.Services
{
    public class HostelService : IHostelService
    {
        private readonly IHostelRepository _hostelRepository;
        private readonly ICustomerRepository _customerRepository;

        public HostelService(IHostelRepository hostelRepository, ICustomerRepository customerRepository)
        {
            _hostelRepository = hostelRepository;
            _customerRepository = customerRepository;
        }

        public int Insert(Hostel hostel)
        {
            _hostelRepository.Insert(hostel);
            return _hostelRepository.SaveChanges();
        }

        public int Update(Hostel hostel)
        {
            _hostelRepository.Update(hostel);
            return _hostelRepository.SaveChanges();
        }

        public Hostel Read(Guid id)
        {
            return _hostelRepository.Read(id);
        }

        public Hostel ReadByCustomerId(Guid customerId)
        {
            return _customerRepository.Read(customerId).Hostel;
        }

        public int Delete(Guid id)
        {
            _hostelRepository.Delete(id);
            return _hostelRepository.SaveChanges();
        }

        public IEnumerable<Hostel> List()
        {
            return _hostelRepository.List();
        }

        public void Dispose()
        {
            _hostelRepository?.Dispose();
        }
    }
}
