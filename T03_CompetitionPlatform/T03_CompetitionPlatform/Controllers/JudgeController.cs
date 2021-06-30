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
            
            if (id != null)
            {
                TempData["CompID"] = id.Value;
                Competition competition = competitionContext.GetDetails(id.Value);
                ViewData["CompName"] = competition.CompetitionName;




                ViewData["selectedCompID"] = id.Value;
                // Get list of staff working in the branch
                compVM.criteriaList = competitionContext.GetCompCriteria(id.Value);
            }
            else
            {
                int newid = (int)TempData.Peek("CompID");
                Competition competition = competitionContext.GetDetails(newid);
                ViewData["CompName"] = competition.CompetitionName;


                ViewData["selectedCompID"] = newid;
                // Get list of staff working in the branch
                compVM.criteriaList = competitionContext.GetCompCriteria(newid);
            };
            
            
            return View(compVM);
        }

        

        // GET: JudgeController/Create
        public ActionResult CreateCriteria()
        {
            int id = (int) TempData.Peek("CompID");


            Competition competition = competitionContext.GetDetails(id);
            ViewData["CompName"] = competition.CompetitionName;

            Criteria criteria = new Criteria();
            //use current competion id for new criteria
            criteria.CompetitionID = id;
             
            return View(criteria);

            
        }

        // POST: JudgeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCriteria(Criteria criteria)
        {
            int id = (int)TempData.Peek("CompID");
            List<Criteria> compcriteira = competitionContext.GetCompCriteria(id);
            int totalweightage = 0;
            for (int i = 0; i < compcriteira.Count; i++)
            {
                totalweightage += compcriteira[i].Weightage;
            }
            if (ModelState.IsValid )
            {
                //Add staff record to database
                criteria.CriteriaID = criteriaContext.Add(criteria);
                //Redirect user to Staff/Index view
                return RedirectToAction("ViewCriteria");
            }
            else
            {
                //Input validation fails, return to the Create view
                //to display error message
                return View(criteria);
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
