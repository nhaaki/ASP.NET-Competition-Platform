using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T03_CompetitionPlatform.Controllers
{
    public class GuestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
