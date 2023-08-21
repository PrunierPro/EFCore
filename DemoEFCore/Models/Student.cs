using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    internal class Student
    {
        [Key] // Default primary key is "int Id" but by adding this tag another property can be defined as a primary key
        public int Id { get; set; }
        [Required] // Equivalent to NOT NULL
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
