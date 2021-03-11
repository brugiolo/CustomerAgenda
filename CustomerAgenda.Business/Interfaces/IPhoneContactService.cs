using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Business.Interfaces
{
    public interface IPhoneContactService
    {
        IEnumerable<PhoneContact> GetAll(Guid customerId, Guid hostelId);
    }
}
