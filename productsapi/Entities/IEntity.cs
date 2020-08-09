using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Entities
{
    interface IEntity
    {
        public int id { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        [DefaultValue(true)]
        public bool status { get; set; }
    }
}
