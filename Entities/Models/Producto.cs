using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Entities.Models
{
    public class Producto : IdentityBase
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}