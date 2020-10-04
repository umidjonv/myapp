using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.DTO
{
    public class BankDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        public string Address { get; set; }

        [Required]
        public string BankAccount { get; set; }

        [Required]
        public int MFO { get; set; }


    }
}
