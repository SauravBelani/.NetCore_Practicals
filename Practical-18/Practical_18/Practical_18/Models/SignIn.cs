using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_18.Models
{
    public class SignIn
    {
        [Required,EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
