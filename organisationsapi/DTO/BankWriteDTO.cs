using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.DTO
{
    public class BankWriteDTO
    {
        public string name { get; set; }

        public string bankAccount { get; set; }

        public Bank bank { get; set; }

        public int MFO { get; set; }

        public string address { get; set; }


    }
}
