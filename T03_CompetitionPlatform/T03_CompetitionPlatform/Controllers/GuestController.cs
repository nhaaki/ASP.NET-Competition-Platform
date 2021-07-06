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

            
            return View(currentSubmissions);
        }

        public ActionResult ViewCompetitorWork(int? competitorID)
        {
            List<CompetitionSubmission> compSubmission = competitionSubmissionContext.GetAllSubmissions();
            foreach (CompetitionSubmission cs in compSubmission)
            {
                if (cs.CompetitorID == competitorID)
                {
                    CompetitionSubmission submission = cs;
                    return View(submission);
                }
            }
            return View();
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
                Ranking = comp.Ranking
            };
            return csVM;

        }

    
    }
}
