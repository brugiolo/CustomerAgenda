using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using CustomerAgenda.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(CustomerAgendaContext context) : base(context)
        {
        }
    }
}
