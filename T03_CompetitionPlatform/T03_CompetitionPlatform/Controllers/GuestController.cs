using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private CommentDAL commentContext = new CommentDAL();
        private CompetitionScoreDAL compscoreContext = new CompetitionScoreDAL();

        public ActionResult Index()
        {

            List<Competition> compList = competitionContext.GetAllCompetitions();
            return View(compList);   
        }

        public ActionResult ViewCompetitors(int? id, string name)
        {
            List<CompetitionSubmission> compSubmission = competitionSubmissionContext.GetAllSubmissions();
            List<CompetitionSubmission> specifiedSubmission = new List<CompetitionSubmission>();
            foreach(CompetitionSubmission cs in compSubmission){
                if (cs.CompetitionID == id)
                {
                    specifiedSubmission.Add(cs);
                }
            }


            List<Competitor> competitorList = competitorContext.GetAllCompetitors();
            List<CompSubmissionViewModel> currentSubmissions = new List<CompSubmissionViewModel>();
            foreach(Competitor c in competitorList)
            {
                foreach (CompetitionSubmission cs in specifiedSubmission)
                {
                    if (c.CompetitorID == cs.CompetitorID)
                    {
                        CompSubmissionViewModel csVM = MapTocsVM(cs, id);
                        currentSubmissions.Add(csVM);
                    }
                } 
            }

            ViewData["CompName"] = name;
            ViewData["CompID"] = id;

            List<Competition> competitions = competitionContext.GetAllCompetitions();
            foreach (Competition x in competitions)
            {
                if (x.CompetitionID == id)
                {
                    if (DateTime.Now < x.StartDate)
                    {
                        ViewData["Status"] = "Not ongoing";
                    }else if (DateTime.Now > x.EndDate)
                    {
                        ViewData["Status"] = "Ended";
                    }else if (DateTime.Now >= x.StartDate && DateTime.Now <= x.EndDate)
                    {
                        ViewData["Status"] = "Ongoing";
                    }
                }
            }

            

            return View(currentSubmissions);
        }

        public ActionResult GuestComment(int? id)
        {
            ViewData["CompID"] = id;
            List<Competition> comps = competitionContext.GetAllCompetitions();
            foreach (Competition c in comps)
            {
                if (c.CompetitionID == id)
                {
                    ViewData["CompName"] = c.CompetitionName;
                    break;
                }
            }
            List<Comment> comments = commentContext.GetAllComments();
            List<Comment> relevantComments = new List<Comment>();
            foreach (Comment c in comments)
            {
                if(c.CompetitionID == id)
                {
                    relevantComments.Add(c);
                }
            }
            return View(relevantComments);
        }

        public ActionResult PostComment(int? id)
        {

            ViewData["CompID"] = id;
            return View();
        }
        public ActionResult ViewCompetitorWork(int? competitorID, int? competitionID)
        {
            List<CompetitionSubmission> compSubmission = competitionSubmissionContext.GetAllSubmissions();
            foreach (CompetitionSubmission cs in compSubmission)
            {
                if (cs.CompetitorID == competitorID && cs.CompetitionID== competitionID)
                {
                    return View(MapTocsVM(cs, cs.CompetitionID));
                }
            }
            return View();
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addVote(CompSubmissionViewModel csvm)
        {
            ViewData["CompName"] = csvm.CompetitionName;
            competitionSubmissionContext.AddVote(csvm.CompetitorID, csvm.CompetitionID);
            HttpContext.Session.SetInt32(csvm.CompetitionID.ToString(), 1);
            return RedirectToAction("ViewCompetitors", new { id = csvm.CompetitionID });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addComment(Comment comment)
        {
            if (!ModelState.IsValid) // validation fails
            {
                TempData["InputEmpty"] = "Your comment can't be empty!";
                return RedirectToAction("PostComment", "Guest", new { id = comment.CompetitionID }); // returns the view with errors
            }

            comment.CommentID = commentContext.Add(comment);
            return RedirectToAction("GuestComment", new { id = comment.CompetitionID });
        }

        public CompSubmissionViewModel MapTocsVM(CompetitionSubmission comp, int? id)
        {
            string compName = "";
            string competitorName = "";
            string competitorSalutation = "";
            DateTime? startDate = default;
            DateTime? endDate = default;
           
            List<Competition> compList = competitionContext.GetAllCompetitions();
            List<Competitor> competitors = competitorContext.GetAllCompetitors();
           
            foreach (Competition c in compList)
            {
                if (c.CompetitionID == id)
                {
                    compName = c.CompetitionName;
                    startDate = c.StartDate;
                    endDate = c.EndDate;
                    break;
                }
            }

            foreach(Competitor c in competitors)
            {
                if (c.CompetitorID == comp.CompetitorID)
                {
                    competitorName = c.CompetitorName;
                    competitorSalutation = c.Salutation;
                    break;
                }
            }
            CompSubmissionViewModel csVM = new CompSubmissionViewModel
            {
                CompetitionName = compName,
                CompetitorName = competitorName,
                Salutation = competitorSalutation,
                CompetitionID = comp.CompetitionID,
                CompetitorID = comp.CompetitorID,
                FileSubmitted = comp.FileSubmitted,
                DateTimeFileUpload = comp.DateTimeFileUpload,
                Appeal = comp.Appeal,
                VoteCount = comp.VoteCount,
                Ranking = comp.Ranking,    
                StartDate = startDate,
                EndDate = endDate
            };
            return csVM;

        }

        public ActionResult FinalRanking(int id)
        {
            List<CompetitionSubmission> competitionSubmissions = competitionSubmissionContext.GetAllSubmissions();
            IEnumerable<CompSubmissionViewModel> topthreelist = new List<CompSubmissionViewModel>();
            List<CompSubmissionViewModel> csVMs = new List<CompSubmissionViewModel>();

            foreach (CompetitionSubmission cs in competitionSubmissions)
            {
                if (cs.CompetitionID == id)
                {
                    csVMs.Add(MapTocsVM(cs, id));
                    topthreelist = csVMs.OrderBy(x => x.Ranking).Take(3);
                }
            }
            return View(topthreelist);
        }

    
    }
}
