using demoday_record.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoday_record.DAL
{
    public class DemodayRecordRepository
    {
        public DemodayRecordContext Context { get; set; }

        public DemodayRecordRepository()
        {
            Context = new DemodayRecordContext();

            // The following checks to see if the database exists.  If not, this makes it and returns 'true'.
            //  If the Db exists, this does nothing and returns false.
            Context.Database.EnsureCreated();
        }

        public void AddUserInformation(Attendee sentAttendee)
        {
            Context.Add(sentAttendee);
            Context.SaveChanges();
        }

        public void SavePhotoFileAndDbEntry(Attendee sentAttendee)
        {
            Attendee dbAttendee = Context.Attendees.FirstOrDefault(a => a.AttendeeName == sentAttendee.AttendeeName);
            Photo builtPhoto = new Photo
            {
                Filename = dbAttendee.EntryTime.ToString(),
                CreationTime = dbAttendee.EntryTime,
                Attendee = dbAttendee
            };
            Context.Add(builtPhoto);
            Context.SaveChanges();
        }
    }
}
