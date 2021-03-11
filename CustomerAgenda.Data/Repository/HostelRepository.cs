using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using CustomerAgenda.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Data.Repository
{
    public class HostelRepository : Repository<Hostel>, IHostelRepository
    {
        public HostelRepository(CustomerAgendaContext context) : base(context)
        {
        }
    }
}
