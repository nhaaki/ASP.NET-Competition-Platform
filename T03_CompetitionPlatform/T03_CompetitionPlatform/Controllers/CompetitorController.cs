using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T03_CompetitionPlatform.Controllers
{
    public class CompetitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
