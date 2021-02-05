using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSPruebaUTP.Models.Request
{
    public class AutenRequest
    {
        [Required]
        public String Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
