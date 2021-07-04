using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T03_CompetitionPlatform.Models;
using Microsoft.AspNetCore.Http;

namespace T03_CompetitionPlatform.Controllers
{
    public class HomeController : Controller
    {
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
            if (loginID == "admin1@lcu.edu.sg" && password == "p@55Admin")
            {
                //Store login ID in session with the key "LoginID"
                HttpContext.Session.SetString("LoginID", loginID);

                //Store user role "Admin" as a string in session with the key "Role"
                HttpContext.Session.SetString("Role", "Admin");

                // Redirect user to the "AdminMain" view through an action
                return RedirectToAction("AdminMain", "Admin");

            }
            else if (loginID == "judge1@lcu.edu.sg" && password == "p@55Admin")
            {
                //Store login ID in session with the key "LoginID"
                HttpContext.Session.SetString("LoginID", loginID);

                //Store user role "Judge" as a string in session with the key "Role"
                HttpContext.Session.SetString("Role", "Judge");

                // Redirect user to the "Index" view through an action
                return RedirectToAction("Index", "Judge");
            }
            else if (loginID == "pg1@hotmail.com" && password == "p@55PG")
            {
                //Store login ID in session with the key "LoginID"
                HttpContext.Session.SetString("LoginID", loginID);

                //Store user role "Judge" as a string in session with the key "Role"
                HttpContext.Session.SetString("Role", "Competitor");

                // Redirect user to the "Index" view through an action
                return RedirectToAction("Index", "Competitor");
            }
            else
            {
                // Store an error message in TempData for display at the index view
                TempData["Message"] = "Invalid Login Credentials!";


                // Redirect user back to the index view through an action
                return RedirectToAction("Index");
            }
        }

        public ActionResult GuestLogin()
        {
            return RedirectToAction("Index", "Guest");
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
