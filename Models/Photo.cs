using System;
using System.ComponentModel.DataAnnotations;

namespace demoday_record.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public string Filename { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Attendee Attendee { get; set; }
    }
}
