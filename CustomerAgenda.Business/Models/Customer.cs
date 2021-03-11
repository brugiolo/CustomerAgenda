using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAgenda.Business.Models
{
    public class Customer : Entity
    {
        [Required]
        public Guid HostelKey { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [NotMapped]
        private List<PhoneContact> _phoneContacts { get; set; }
        
        public List<PhoneContact> PhoneContacts
        {
            get { return _phoneContacts ?? new List<PhoneContact>(); }
            set { _phoneContacts = value; }
        }
        
        [NotMapped]
        private List<Address> _addresses { get; set; }
        
        public List<Address> Addresses
        {
            get { return _addresses ?? new List<Address>(); }
            set { _addresses = value; }
        }
    }
}
