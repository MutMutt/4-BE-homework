using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE_4_customers.Models
{
    public class Authenticate
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
