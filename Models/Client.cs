using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECBoxAPI.Models
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int locker { get; set; }
        public int phone { get; set; }
        public int cellphone { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string province { get; set; }
        public string state { get; set; }
        public string district { get; set; }
    }
}
