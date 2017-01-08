using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demoday_record.Models
{
    public class Attendee
    {
        public string AttendeeName { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public long EntryTime { get; set; }
    }
}