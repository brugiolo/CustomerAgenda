using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAgenda.Api.ViewModels
{
    public class CustomerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public HostelViewModel Hostel { get; set; }
        public List<AddressViewModel> Addresses { get; set; }
        public List<PhoneContacViewModel> PhoneContacts { get; set; }
    }
}
