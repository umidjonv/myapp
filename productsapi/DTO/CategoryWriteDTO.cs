using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class CategoryWriteDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public int parentId { get; set; }

        public Category parent { get; set; }
    }
}
