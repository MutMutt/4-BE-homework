using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE_4_customers.Models
{
    public class Order
    {
        [Key]

        public int id { get; set; }
        public int customer_id { get; set; }
        public int product_id { get; set; }
    }
}
