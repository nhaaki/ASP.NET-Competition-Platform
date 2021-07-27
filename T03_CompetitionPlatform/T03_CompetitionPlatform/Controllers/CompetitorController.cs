using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T03_CompetitionPlatform.DAL;
using T03_CompetitionPlatform.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace T03_CompetitionPlatform.Controllers
{
    public class CompetitorController : Controller
    {
        private CompetitionDAL competitionContext = new CompetitionDAL();
        private CompetitorDAL competitorContext = new CompetitorDAL();
        private CompetitionSubmissionDAL competitionSubmissionContext = new CompetitionSubmissionDAL();

        public IActionResult Index()
        {
            List<Competition> competitionList = competitionContext.GetAllCompetitions();
            return View(competitionList);
        }

        // GET: Competitor/Register
        [HttpGet]
        public ActionResult CompetitorRegister()
        {
            // In case need again.
            ViewData["SalutationList"] = GetSalutations();
            return View();
        }

        // List for salutations
        private List<SelectListItem> GetSalutations()
        {
            List<SelectListItem> salutations = new List<SelectListItem>();
            salutations.Add(new SelectListItem { Value = "Dr", Text = "Dr" });
            salutations.Add(new SelectListItem { Value = "Mr", Text = "Mr" });
            salutations.Add(new SelectListItem { Value = "Ms", Text = "Ms" });
            salutations.Add(new SelectListItem { Value = "Mrs", Text = "Mrs" });
            salutations.Add(new SelectListItem { Value = "Mdm", Text = "Mdm" });

            return salutations;
        }

        // POST: Competitor/Register
        [HttpPost]
        public ActionResult CompetitorRegister(Competitor compt)
        {
            // In case need again.
            ViewData["SalutationList"] = GetSalutations();

            if (ModelState.IsValid)
            {
                compt.CompetitorID = competitorContext.CompetitorRegister(compt);

                return RedirectToAction("Index");
            }
            else
            {
                return View(compt);
            }
        }
  
        // POST: Competitor/JoinCompetition
        [HttpGet]
        public ActionResult JoinCompetition(CompetitionSubmission comptSub)
        {
            ViewData["SalutationList"] = GetSalutations();
            comptSub.CompetitorID = (int)HttpContext.Session.GetInt32("CompetitorID");
            // VoteCount starts at 0
            comptSub.VoteCount = 0;

            if (ModelState.IsValid)
            {
                // Successful addition to database, however there is no message to show that it succeeded
                // or that the user cannot see if he has already joined the competition nor if he can
                // join due to the date.

                // Add to database
                competitionSubmissionContext.JoinCompetition(comptSub);

                // Redirect to list view
                return RedirectToAction("Index");
            }
            else
            {
                // Redirect to list view
                return RedirectToAction("Index");
            }
        }
    }
}
