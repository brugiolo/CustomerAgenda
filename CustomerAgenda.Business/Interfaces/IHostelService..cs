using CustomerAgenda.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAgenda.Business.Interfaces
{
    public interface IHostelService
    {
        int Insert(Hostel hostel);
        Hostel Read(Guid id);
        Hostel ReadByCustomerId(Guid customerId);
        int Update(Hostel hostel);
        int Delete(Guid id);
        IEnumerable<Hostel> List();
    }
}
