using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE_4_customers.Models
{
    public class Customer
    {
        [Key]

        public int id { get; set; }
        public string name { get; set; }
    }
}
