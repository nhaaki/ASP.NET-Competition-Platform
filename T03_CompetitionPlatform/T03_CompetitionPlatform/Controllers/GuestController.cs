using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T03_CompetitionPlatform.DAL;
using T03_CompetitionPlatform.Models;

namespace T03_CompetitionPlatform.Controllers
{
    public class GuestController : Controller
    {

        private CompetitionDAL competitionContext = new CompetitionDAL();

        public ActionResult Index()
        {

            List<Competition> compList = competitionContext.GetAllCompetitions();
            return View(compList);   
        }

        public ActionResult ViewCriteria(int? id)
        {
            return View();
        }
    }
}
