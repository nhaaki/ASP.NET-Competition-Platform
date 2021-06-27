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




        // GET: JudgeController
        public ActionResult Index()
        {
            

            List<Competition> compList = competitionContext.GetAllCompetitions();
            return View(compList);
        }

        

        // GET: JudgeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JudgeController/Create
        public ActionResult CreateCriteria(int? id)
        {
            Competition competition = competitionContext.GetDetails(id.Value);
            ViewData["CompName"] = competition.CompetitionName;
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
