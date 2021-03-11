using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Business.Interfaces
{
    public interface IAddressService
    {
        IEnumerable<Address> GetAll(Guid customerId, Guid hostelId);
    }
}
