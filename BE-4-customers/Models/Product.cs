using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BE_4_customers.Models
{
    public class Product
    {
        [Key]

        public int id { get; set; }
        public string name { get; set; }
        
    }
}
