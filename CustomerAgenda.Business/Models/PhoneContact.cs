using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerAgenda.Business.Models
{
    public class PhoneContact : Entity
    {
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }

        [Required]
        public PhoneContactType Type { get; set; }

        [Required]
        [MaxLength(30)]
        public string Number { get; set; }
    }

    public enum PhoneContactType
    {
        Local = 1,
        Mobile = 2
    }
}
