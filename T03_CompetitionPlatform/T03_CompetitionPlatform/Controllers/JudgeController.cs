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
    public class JudgeController : Controller
    {
        private AreaInterestDAL areaContext = new AreaInterestDAL();
        private CompetitionDAL competitionContext = new CompetitionDAL();
        private JudgesDAL judgeContext = new JudgesDAL();
        private CompetitorDAL competitorContext = new CompetitorDAL();
        private CompetitionSubmissionDAL competitorSubmissionContext = new CompetitionSubmissionDAL();
        private CriteriaDAL criteriaContext = new CriteriaDAL();




        // GET: JudgeController
        public ActionResult Index()
        {
            

            List<Competition> compList = competitionContext.GetAllCompetitions();
            return View(compList);
        }



        // GET: JudgeController/ViewCriteria/5
        public ActionResult ViewCriteria(int? id)
        {
            // Stop accessing the action if not logged in
            // or account not in the "Staff" role
            
            
            CompetitionViewModel compVM = new CompetitionViewModel();
            compVM.compList = competitionContext.GetAllCompetitions();
            
            
            
            ViewData["selectedCompID"] = id.Value;
            // Get list of staff working in the branch
            compVM.criteriaList = competitionContext.GetCompCriteria(id.Value);
            
            
            return View(compVM);
        }

        

        // GET: JudgeController/Create
        public ActionResult CreateCriteria(int? id)
        {
            Competition competition = competitionContext.GetDetails(id.Value);
            ViewData["CompName"] = competition.CompetitionName;
            TempData["CompID"] = id.Value;
            return View(competition);

            
        }

        // POST: JudgeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JudgeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JudgeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JudgeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JudgeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
