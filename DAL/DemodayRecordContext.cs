using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoday_record.Models;
using demoday_record.Private;
using Microsoft.EntityFrameworkCore;

namespace demoday_record.DAL
{
    public class DemodayRecordContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Photo> Photos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                    .UseMySql(PrivateParameters.MySQLParameterString); //Requires access to the private MySQL conntection string 
    }
}
