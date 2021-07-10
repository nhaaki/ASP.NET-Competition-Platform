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
        private CommentDAL commentContext = new CommentDAL();

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
        public ActionResult addVote(int competitorID, int competitionId)
        {
            competitionSubmissionContext.AddVote(competitorID, competitionId);
            return RedirectToAction("ViewCompetitors", competitionId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addComment(Comment comment)
        {
            comment.CommentID = commentContext.Add(comment);
            return RedirectToAction("GuestComment", new { id = comment.CompetitionID });
        }

        public CompSubmissionViewModel MapTocsVM(CompetitionSubmission comp, int? id)
        {
            string compName = "";
            string competitorName = "";
            string competitorSalutation = "";
           
            List<Competition> compList = competitionContext.GetAllCompetitions();
            List<Competitor> competitors = competitorContext.GetAllCompetitors();
           
            foreach (Competition c in compList)
            {
                if (c.CompetitionID == id)
                {
                    compName = c.CompetitionName;
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
            };
            return csVM;

        }

    
    }
}
