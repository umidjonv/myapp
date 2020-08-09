using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    public class ProductImages
    {
        [Key]
        public int id { get; set; }
        public Product productId { get; set; }
        public string fileName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int status { get; set; }

    }
}
