using productsapi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class CategoryWriteDTO
    {
        //public Guid id { get; set; }

        public string name { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid parentId { get; set; }

        public Category parent { get; set; }

    }
}
