using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAgenda.Api.ViewModels
{
    public class PhoneContacViewModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public PhoneContactTypeViewModel Type { get; set; }
        public string Number { get; set; }
    }

    public enum PhoneContactTypeViewModel
    {
        Local = 1,
        Mobile = 2
    }
}
