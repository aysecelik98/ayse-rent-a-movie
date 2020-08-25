using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyPrototype.Models;

namespace VidlyPrototype.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        [Authorize(Roles = RoleName.IsAdministrator)]
        public ActionResult Create()
        {
            return View();
        }
    }
}