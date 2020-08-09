using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class ProductReadDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public float price { get; set; }

        public float salePrice { get; set; }

        public Category category { get; set; }
    }
}
