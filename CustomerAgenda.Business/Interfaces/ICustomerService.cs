using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Business.Interfaces
{
    public interface ICustomerService
    {
        int Insert(Customer customer);
        Customer Read(Guid id);
        int Update(Customer customer);
        int Delete(Guid id);
        IEnumerable<Customer> List();
    }
}
