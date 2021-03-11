using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using CustomerAgenda.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerAgendaContext context) : base(context)
        {
        }
    }
}
