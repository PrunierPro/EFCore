using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2.Models
{
    internal enum RoomStatus
    {
        FREE,
        OCCUPIED,
        CLEANING
    }

    [Table("rooms")]
    internal class Room
    {
        [Column("room_number")]
        [Key]
        public int Number { get; set; }

        [Column("status")]
        [Required]
        public RoomStatus Status { get; set; }

        [Column("bed_amount")]
        [Required]
        public int BedAmount { get; set; }

        [Column("price")]
        [Required]
        public decimal Price { get; set; }
    }
}
