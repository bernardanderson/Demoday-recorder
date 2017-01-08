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
    }
}
