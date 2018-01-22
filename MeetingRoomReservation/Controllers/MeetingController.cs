using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingRoomReservation.Controllers
{
    public class MeetingController : Controller
    {
        //
        // GET: /Meeting/
        public ActionResult FindRooms()
        {
            return View();
        }
	}
}