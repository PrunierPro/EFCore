using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2.Models
{
    [Table("clients")]
    internal class Client
    {
        [Column("client_id")]
        public int Id { get; set; }

        [Column("last_name")]
        [Required]
        public string? LastName { get; set; }

        [Column("first_name")]
        [Required]
        public string? FirstName { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }
    }
}
