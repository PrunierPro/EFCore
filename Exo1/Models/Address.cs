using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exo1.Models
{
    [Table("addresses")]
    internal class Address
    {
        [Column ("address_id")]
        public int Id { get; set; }
        [Required]
        [Column ("number")]
        public int? Number { get; set; }
        [Column ("complement")]
        public string? Complement { get; set; }
        [Required]
        [Column ("name")]
        public string? Name { get; set; }
        [Required]
        [Column ("commune")]
        public string? Commune { get; set; }
        [Required]
        [Column ("postal_code")]
        public int? PostalCode { get; set; }

        public override string ToString()
        {
            return $"Addresse (ID: {Id}): {Number} {Name} {Complement} {Commune} {PostalCode}";
        }
    }
}
