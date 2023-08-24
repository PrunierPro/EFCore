using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2.Models
{
    internal enum BookingStatus
    {
        PLANNED,
        IN_PROGRESS,
        DONE,
        CANCELLED
    }
    [Table("bookings")]
    internal class Booking
    {
        [Column("booking_id")]
        public int Id { get; set; }

        [Column("status")]
        [Required]
        public BookingStatus Status { get; set; }

        [Column("rooms")]
        public List<Room> Rooms { get; set; } = new List<Room>();

        [ForeignKey("client_id")]
        [Column("client_id")]
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
