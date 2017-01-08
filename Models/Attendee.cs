using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demoday_record.Models
{
    public class Attendee
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string AttendeeName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime RecordEntry { get; set; }
    }
}