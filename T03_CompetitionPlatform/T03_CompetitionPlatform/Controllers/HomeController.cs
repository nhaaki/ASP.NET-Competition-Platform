using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T03_CompetitionPlatform.Models;
using Microsoft.AspNetCore.Http;
using T03_CompetitionPlatform.DAL;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace T03_CompetitionPlatform.Controllers
{
    

    public class HomeController : Controller
    {
        private JudgesDAL judgeContext = new JudgesDAL();
        private AreaInterestDAL areaContext = new AreaInterestDAL();
        private CompetitorDAL competitorContext = new CompetitorDAL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        // Activates redirect to login button, to login.cshtml
        [HttpPost]
        public ActionResult redirectLogin(IFormCollection formData)
        {
            return View("Login");
        }

        // Activates redirect to register button, to register.cshtml
        [HttpPost]
        public ActionResult redirectRegister(IFormCollection formData)
        {
            return RedirectToAction("Register");
        }

        [HttpPost]
        public ActionResult cjpLogin(IFormCollection formData)
        {
            // Read inputs from textboxes
            // Email address converted to lowercase
            
            string loginID = formData["txtLoginID"].ToString().ToLower();
            string password = formData["txtPassword"].ToString();
            List<Judge> judgeList = judgeContext.GetAllJudges();
            List<Competitor> competitorList = competitorContext.GetAllCompetitors();
            if (loginID == "admin1@lcu.edu.sg" && password == "p@55Admin")
            {
                //Store login ID in session with the key "LoginID"
                HttpContext.Session.SetString("LoginID", loginID);

                //Store user role "Admin" as a string in session with the key "Role"
                HttpContext.Session.SetString("Role", "Admin");


                // Redirect user to the "AdminMain" view through an action
                return RedirectToAction("AdminMain", "Admin");
            }
            else
            {

                foreach (var item in judgeList)
                {
                    if (loginID == item.EmailAddr.ToLower() && password == item.Password)
                    {
                        Debug.WriteLine("My debug string here");

                        //Store login ID in session with the key "LoginID"
                        HttpContext.Session.SetString("LoginID", loginID);

                        //Store user role "Judge" as a string in session with the key "Role"
                        HttpContext.Session.SetString("Role", "Judge");

                       

                        // Redirect user to the "Index" view through an action
                        return RedirectToAction("Index", "Judge");
                    };
                };
                foreach (var item2 in competitorList)
                {
                    if (loginID == item2.EmailAddr.ToLower() && password == item2.Password)
                    {
                        //Store login ID in session with the key "LoginID"
                        HttpContext.Session.SetString("LoginID", loginID);

                        //Store login ID in session with the key "CompetitorID"
                        HttpContext.Session.SetInt32("CompetitorID", item2.CompetitorID);

                        //Store user role "Judge" as a string in session with the key "Role"
                        HttpContext.Session.SetString("Role", "Competitor");

                        // Redirect user to the "Index" view through an action
                        return RedirectToAction("Index", "Competitor");
                    }

                };
            // Store an error message in TempData for display at the index view
            TempData["Message"] = "Invalid Login Credentials!";

            // Redirect user back to the index view through an action
            return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult GuestLogin()
        {
            //Store voted boolean value in session with the key "Voted"
            HttpContext.Session.SetInt32("Voted", 0);

            //Store user role "Guest" in session with the key "Role"
            HttpContext.Session.SetString("Role", "Guest");

            // Redirect user to the "Index" view through an action
            return RedirectToAction("Index", "Guest");
        }


        public ActionResult guestLogout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult adminLogout()
        {
            HttpContext.Session.Clear();

            //Call the index action of Home Controller 
            return RedirectToAction("Index");
        }

        public ActionResult competitorLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult judgeRegister()
        {
            List<SelectListItem> aoiList = new List<SelectListItem>();

            foreach(var item in GetAllAOI())
            {
                aoiList.Add(new SelectListItem
                {
                    Value = Convert.ToString(item.AreaInterestID),
                    Text = item.Name


                }); ;
            }

            ViewData["AOIList"] = aoiList;



            return View();
        }

        [HttpPost]
        public ActionResult judgeRegister(Judge judge)
        {
            ViewData["AOIList"] = GetAllAOI();

            if (ModelState.IsValid)
            {
                //Add staff record to database
                judge.JudgeID = judgeContext.Add(judge);
                //Redirect user to Home/Index view
                return RedirectToAction("Index");
            }
            else
            {
                //Input validation fails, return to the Create view
                //to display error message
                

                return View(judge);
            }
        }

        private List<AreaInterest> GetAllAOI()
        {
            
            
            // Get a list of branches from database
            List<AreaInterest> aoiList = areaContext.GetAllArea();
            // Adding a select prompt at the first row of the branch list
            
            return aoiList;
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
