using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.DTO
{
    public class BankReadDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string bankAccount { get; set; }

        public int MFO { get; set; }


    }
}
