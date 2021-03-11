using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerAgenda.Business.Models
{
    public class Address : Entity
    {
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string Number { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get;set; }
    }
}
