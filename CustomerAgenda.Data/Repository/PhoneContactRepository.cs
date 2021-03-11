using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using CustomerAgenda.Data.Context;

namespace CustomerAgenda.Data.Repository
{
    public class PhoneContactRepository : Repository<PhoneContact>, IPhoneContactRepository
    {
        public PhoneContactRepository(CustomerAgendaContext context) : base(context)
        {
        }
    }
}
