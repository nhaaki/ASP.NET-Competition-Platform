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



        // GET: JudgeController/CreateCriteria
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

        // POST: JudgeController/CreateCriteria
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
            totalweightage = totalweightage + criteria.Weightage
            if (ModelState.IsValid && totalweightage <= 100 )
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
                ViewData["errormsg"] = "Weightage has exceeded 100%(current: " + totalweightage + "%)" ;
                ViewData["error"] = true;
                
                return View(criteria);
            }

        }

        // GET: JudgeController/Edit/5
        public ActionResult EditCriteria(int? id)
        {
            int compid = (int)TempData.Peek("CompID");


            Competition competition = competitionContext.GetDetails(compid);
            ViewData["CompName"] = competition.CompetitionName;


            Criteria criteria = criteriaContext.GetDetails(id.Value);
            criteria.CriteriaID = id.Value;
            if (criteria == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index");
            }
            return View(criteria);

        }

        // POST: JudgeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCriteria(Criteria criteria)
        {
            int id = (int)TempData.Peek("CompID");
            List<Criteria> compcriteria = competitionContext.GetCompCriteria(id);
            int totalweightage = 0;
            for (int i = 0; i < compcriteria.Count; i++)
            {
                totalweightage += compcriteria[i].Weightage;
            }
            totalweightage = totalweightage - criteriaContext.GetDetails(criteria.CriteriaID).Weightage + criteria.Weightage;
            if (ModelState.IsValid && totalweightage <= 100)
            {
                //Add staff record to database
                criteria.CriteriaID = criteriaContext.Update(criteria);
                //Redirect user to Staff/Index view
                return RedirectToAction("ViewCriteria");
            }
            else
            {
                //Input validation fails, return to the Create view
                //to display error message
                ViewData["errormsg"] = "Weightage has exceeded 100%(current: " + totalweightage + "%)";
                ViewData["error"] = true;

                return View(criteria);
            }
        }

        // GET: JudgeController/Delete/5
        public ActionResult DeleteCriteria(int? id)
        {
            int compid = (int)TempData.Peek("CompID");


            Competition competition = competitionContext.GetDetails(compid);
            ViewData["CompName"] = competition.CompetitionName;


            Criteria criteria = criteriaContext.GetDetails(id.Value);
            if (criteria == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index");
            }
            return View(criteria);
        }

        // POST: JudgeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCriteria(Criteria criteria)
        {
            // Delete the criteria record from database
            criteriaContext.Delete(criteria.CriteriaID);
            return RedirectToAction("ViewCriteria");
        }
    }
}
