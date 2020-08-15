using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        [MaxLength(500)]
        public string description { get; set; }

        public float price { get; set; }

        public float salePrice { get; set; }

        [Required]
        public Category category { get; set; }

        public bool status { get; set; }

        //public int orgId { get; set; }

        //public int brandId { get; set; }

        //public DateTime createdAt { get; set; }

        //public DateTime updatedAt { get; set; }

    }
}
