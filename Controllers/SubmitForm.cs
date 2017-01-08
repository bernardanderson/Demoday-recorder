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
        public async Task<IActionResult> Upload(Attendee sentAttendee, string submitform)
        {
            long submitTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            DemodayRecordRepository newDemodayRepo = new DemodayRecordRepository();

            sentAttendee.EntryTime = submitTime;
            newDemodayRepo.AddUserInformation(sentAttendee);

            if (submitform == "withpic")
            {
                Picture capturedPicture = await new TakePhoto().CameraSnapshot(submitTime);
                newDemodayRepo.SavePhotoFileAndDbEntry(sentAttendee);
            }

            return RedirectToAction("ThankYou", "Home");
        }
    }
}
