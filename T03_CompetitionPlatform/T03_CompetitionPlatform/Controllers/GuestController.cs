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
        private CompetitorDAL competitorContext = new CompetitorDAL();
        private CompetitionSubmissionDAL competitionSubmissionContext = new CompetitionSubmissionDAL();

        public ActionResult Index()
        {

            List<Competition> compList = competitionContext.GetAllCompetitions();
            return View(compList);   
        }

        public ActionResult ViewCompetitors(int? id)
        {
            CompetitionSubmission compSubmission = competitionSubmissionContext.GetDetails(id.Value);
            List<Competitor> competitorList = competitorContext.GetAllCompetitors();
            foreach(Competitor c in competitorList)
            {
                if (c.CompetitorID == compSubmission.CompetitorID){
                    return View(compSubmission);
                }
            }
            return View();
        }
    }
}
