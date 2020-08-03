using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal salePrice { get; set; }
        public Guid orgId { get; set; }
        public Guid categoryId { get; set; }
        public Guid brandId { get; set; }
        public TimeSpan createdAt { get; set; }
        public TimeSpan updatedAt { get; set; }
        public int status { get; set; }
    }
}
