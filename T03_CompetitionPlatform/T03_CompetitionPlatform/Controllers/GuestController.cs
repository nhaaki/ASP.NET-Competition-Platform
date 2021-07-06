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

        public ActionResult ViewCompetitors(int? id)
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

            
            return View(currentSubmissions);
        }

        public CompSubmissionViewModel MapTocsVM(CompetitionSubmission comp, int? id)
        {
            string compName = "";
            List<Competition> compList = competitionContext.GetAllCompetitions();
            foreach (Competition c in compList)
            {
                if (c.CompetitionID == id)
                {
                    compName = c.CompetitionName;
                    break;
                }
            }

            CompSubmissionViewModel csVM = new CompSubmissionViewModel
            {
                CompetitionName = compName,
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
