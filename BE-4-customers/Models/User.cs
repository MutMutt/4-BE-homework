using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_4_customers.Models
{
    public class User
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string passwordhash { get; set; }
    }
}
