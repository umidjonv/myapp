using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Entites
{
    public class Bank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string name { get; set; }

        [Required]
        public string bankAccount { get; set; }

        [Required]
        public int MFO { get; set; }

        [Required]
        public string address { get; set; }

        public bool status { get; set; }

    }
}
