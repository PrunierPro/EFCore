using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1.Models
{
    internal class Address
    {
        public int Id { get; set; }
        [Required]
        public int? Number { get; set; }
        public string? Complement { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Commune { get; set; }
        [Required]
        public int? PostalCode { get; set; }

        public override string ToString()
        {
            return $"Addresse: {Id}, {Number}, {(Complement is not null || !Complement.Equals("") ? $"{Complement}, " : "")}{Name}, {Commune}, {PostalCode}";
        }
    }
}
