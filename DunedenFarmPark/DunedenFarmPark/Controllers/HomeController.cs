using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DunedenFarmPark.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult WhatsOffered()
        {
            ViewBag.Message = "What we offer.";

            return View();
        }

        public ActionResult MeetOurAnimals()
        {
            ViewBag.Message = "Meet Hurmee";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We will reply as quickly as possible to your query." + Environment.NewLine + "If emailing please include a landline contact number and time when you would be available for us to call you to discuss your requirements.";

            ViewBag.Phone = "03 476 7100";

            ViewBag.Mobile = "021 02972411";

            ViewBag.Email = "sue@dunedenfarmpark.co.nz";

            ViewBag.Address = "Dun Eden Farm Park,17 Ettrick Street,Glenross,Dunedin 9011";

            return View();
        }
    }
}