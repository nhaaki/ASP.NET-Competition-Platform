using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using T03_CompetitionPlatform.DAL;
using T03_CompetitionPlatform.Models;

namespace T03_CompetitionPlatform.Controllers
{
    public class CompetitorController : Controller
    {
        private CompetitionDAL competitionContext = new CompetitionDAL();
        public IActionResult Index()
        {
            List<Competition> competitionList = competitionContext.GetAllCompetitions();
            return View(competitionList);
        }
    }
}
