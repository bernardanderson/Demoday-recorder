using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoday_record.Models;
using demoday_record.DAL;

namespace demoday_record.Controllers
{
    public class SubmitForm : Controller
    {
        [HttpPost]
        public IActionResult Upload([FromForm]Attendee sentAttendee, string submitform)
        {
            DemodayRecordRepository newDemodayRepo = new DemodayRecordRepository();

            sentAttendee.EntryTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            newDemodayRepo.AddUserInformation(sentAttendee);

            if (submitform == "withpic")
            {

            }

            return RedirectToAction("ThankYou", "Home");
        }
    }
}
