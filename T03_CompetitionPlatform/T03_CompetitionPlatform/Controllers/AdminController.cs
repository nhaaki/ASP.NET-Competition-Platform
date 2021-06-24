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
    public class AdminController : Controller
    {
        private AreaInterestDAL areaContext = new AreaInterestDAL();
        private CompetitionDAL competitionContext = new CompetitionDAL();
        private JudgesDAL judgeContext = new JudgesDAL();
        private CompetitorDAL competitorContext = new CompetitorDAL();


        // GET: AdminController
        public ActionResult Index()
        {
            // Stop accessing the action if not logged in
            // or account not in the "Staff" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            List<AreaInterest> areaList = areaContext.GetAllArea();
            return View(areaList);
        }

        public ActionResult AdminMain()
        {
            // Stop accessing the action if not logged in
            // or account not in the "Staff" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "Admin"))
            {
                return RedirectToAction("Index", "Home");
            }

            // Get count of totala areas
            List<AreaInterest> areaList = areaContext.GetAllArea();

            int count = 0;
            foreach (AreaInterest area in areaList)
            {
                count += 1;
            }

            TempData["areaCount"] = Convert.ToString(count);

            // Get count of total competitions
            List<Competition> competitionList = competitionContext.GetAllCompetitions();

            int count1 = 0;
            foreach (Competition competitions in competitionList)
            {
                count1 += 1;
            }

            TempData["competitionCount"] = Convert.ToString(count1);

            // Get count of total judge
            List<Judge> judgeList = judgeContext.GetAllJudges();

            int count2 = 0;
            foreach (Judge judges in judgeList)
            {
                count2 += 1;
            }

            TempData["judgesCount"] = Convert.ToString(count2);

            // Get count of total competitors
            List<Competitor> competitorsList = competitorContext.GetAllCompetitors();

            int count3 = 0;
            foreach (Competitor competitors in competitorsList)
            {
                count3 += 1;
            }

            TempData["competitorsCount"] = Convert.ToString(count3);



            return View("/Views/Admin/AdminMain.cshtml");

            
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateAreaView()
        {
            return View("/Views/Admin/CreateAreaView.cshtml");
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateArea(AreaInterest area)
        {
            if (ModelState.IsValid)
            {
                //Add staff record to database
                area.AreaInterestID = areaContext.Add(area);
                //Redirect user to Staff/Index view
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                //Input validation fails, return to the Create view
                //to display error message
                return View("/Views/Admin/CreateAreaView.cshtml",area);
            }

        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
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

        // GET: AdminController/Delete/5
        public ActionResult DeleteArea(int? id)
        {
            // Stop accessing the action if not logged in
            // or account not in the "Staff" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index", "Admin");
            }

            AreaInterest area = areaContext.GetDetails(id.Value);

            if (area == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index", "Admin");
            }

            if (id != null)
            {
                int theId = Convert.ToInt32(id);

                bool checkCompetitions = competitionContext.checkIfCompetitionExists(theId);

                bool checkJudges = judgeContext.checkIfJudgeExists(theId);

                if (checkCompetitions == true || checkJudges == true)
                {
                    TempData["AreaDeleteMessage"] = "Area has competition(s)! or judge(s) assigned!";

                    return RedirectToAction("Index", "Admin");
                }
            }



            return View(area);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteArea(AreaInterest area)
        {
            // Delete the area record from database
            areaContext.DeleteArea(area.AreaInterestID);
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult AreasOfInterests()
        {
            return View("~/Views/Admin/AreasOfInterests.cshtml");
        }
    }
}
