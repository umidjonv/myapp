using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Entites
{
    public class Organisation
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(200)]
        public string name { get; set; }

        [MaxLength(500)]
        public  string description { get; set; }

        [Required]
        public  string orgAddress { get; set; }

        [Required]
        [MaxLength(70)]
        public string telNumber { get; set; }

        public bool status { get; set; }

        public Bank bankDetails { get; set; }
    }
}
