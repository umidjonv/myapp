using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.DTO
{
    public class OrgWriteDTO
    {
        public string name { get; set; }

        public string description { get; set; }

        public string orgAddress { get; set; }

        public string telNumber {get; set;}

        public int bankId { get; set; }

        public Bank bankDetails { get; set; }
    }
}
