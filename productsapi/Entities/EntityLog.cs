using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Entities
{
    public class EntityLog : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        [DefaultValue(true)]
        public bool status { get; set; }

        public string table { get; set; }
    }
}
