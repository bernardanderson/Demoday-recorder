using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoday_record.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace demoday_record.Controllers
{
    public class SubmitForm : Controller
    {
        [HttpPost]
        public IActionResult Upload([FromForm]Attendee sentAttendee, string submitform)
        {
            if (submitform == "withpic")
            {
                return Ok(sentAttendee + submitform);
            }
            else
            {
                return Ok(sentAttendee + submitform);
            }
        }
    }
}
