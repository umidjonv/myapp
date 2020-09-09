﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.DTO
{
    public class OrgReadDTO
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string orgAddress { get; set; }

        public string telNumber { get; set; }

        public string bankName { get; set; }

    }
}
