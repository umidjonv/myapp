﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Entites
{
    public class Organisation:BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(500)]
        public  string Description { get; set; }

        [Required]
        public  string Address { get; set; }

        [Required]
        [MaxLength(70)]
        public string PhoneNumber { get; set; }

        public int? BankId { get; set; }
        public virtual Bank BankDetails { get; set; }
    }
}
