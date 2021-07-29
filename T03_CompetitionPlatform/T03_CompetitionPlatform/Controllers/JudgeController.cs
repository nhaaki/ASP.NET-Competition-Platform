﻿using Microsoft.AspNetCore.Http;
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

        private CompetitionDAL competitionContext = new CompetitionDAL();
        private JudgesDAL judgeContext = new JudgesDAL();
        private CompetitorDAL competitorContext = new CompetitorDAL();
        private CompetitionSubmissionDAL competitorSubmissionContext = new CompetitionSubmissionDAL();
        private CriteriaDAL criteriaContext = new CriteriaDAL();
        private CompetitionJudgeDAL compjudgeContext = new CompetitionJudgeDAL();
        private CompetitionScoreDAL compscoreContext = new CompetitionScoreDAL();





        // GET: JudgeController
        public ActionResult Index()
        {


            List<Competition> compList = competitionContext.GetAllCompetitions();

            List<CompetitionJudge> compjudgelist = compjudgeContext.GetAllCompetitionJudge();

            string loggedin = (string)TempData.Peek("Loggedin");

            Judge userlogged = judgeContext.Getlogin(loggedin);

            List<int> compinvolvedID = new List<int>();



            for (int i = 0; i < compjudgelist.Count; i++)
            {
                if (compjudgelist[i].JudgeID == userlogged.JudgeID)
                {
                    compinvolvedID.Add(compjudgelist[i].CompetitionID);
                }
            }

            List<Competition> compinvolvedList = new List<Competition>();


            for (int j = 0; j < compList.Count; j++)
            {
                for (int i = 0; i < compinvolvedID.Count; i++)
                {
                    if (compList[j].CompetitionID == compinvolvedID[i])
                    {
                        compinvolvedList.Add(compList[j]);
                    }

                }
            }



            return View(compinvolvedList);
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
            int id = (int)TempData.Peek("CompID");


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
            totalweightage = totalweightage + criteria.Weightage;
            if (ModelState.IsValid && totalweightage <= 100)
            {
                //Add criteria record to database
                criteria.CriteriaID = criteriaContext.Add(criteria);
                //Redirect user to Judge/ViewCriteria/ view
                return RedirectToAction("ViewCriteria");
            }
            else
            {
                //Auto change the criteria's weightage so that total is still 100
                criteria.Weightage = 100 - (totalweightage - criteria.Weightage);
                //Add criteria record to database
                criteria.CriteriaID = criteriaContext.Add(criteria);
                //Redirect user to Judge/ViewCriteria/ view
                return RedirectToAction("ViewCriteria");
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
                //Auto change the criteria's weightage so that total is still 100
                criteria.Weightage = 100 - (totalweightage - criteria.Weightage);
                //Add criteria record to database
                criteria.CriteriaID = criteriaContext.Add(criteria);
                //Redirect user to Judge/ViewCriteria/ view
                return RedirectToAction("ViewCriteria");
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


        public ActionResult ViewSubmission()
        {
            int compid = (int)TempData.Peek("CompID");
            List<CompetitionSubmission> compSubmission = competitorSubmissionContext.GetAllSubmissions();
            List<CompetitionSubmission> specifiedSubmission = new List<CompetitionSubmission>();
            foreach (CompetitionSubmission cs in compSubmission)
            {
                if (cs.CompetitionID == compid)
                {
                    specifiedSubmission.Add(cs);
                }
            }


            List<Competitor> competitorList = competitorContext.GetAllCompetitors();
            List<CompSubmissionViewModel> currentSubmissions = new List<CompSubmissionViewModel>();
            foreach (Competitor c in competitorList)
            {
                foreach (CompetitionSubmission cs in specifiedSubmission)
                {
                    if (c.CompetitorID == cs.CompetitorID)
                    {
                        CompSubmissionViewModel csVM = MapTocsVM(cs, compid);
                        currentSubmissions.Add(csVM);
                    }
                }
            }

            ViewData["CompName"] = competitionContext.GetDetails(compid).CompetitionName;
            ViewData["CompID"] = compid;





            return View(currentSubmissions);
        }

        public ActionResult ViewCompetitorWork(int? competitorID, int? competitionID)
        {
            List<CompetitionSubmission> compSubmission = competitorSubmissionContext.GetAllSubmissions();
            foreach (CompetitionSubmission cs in compSubmission)
            {
                if (cs.CompetitorID == competitorID && cs.CompetitionID == competitionID)
                {
                    return View(MapTocsVM(cs, cs.CompetitionID));
                }
            }
            return View();
        }

        public ActionResult ViewScores(int? competitionid, int? competitorid)
        {
            List<CompetitionScore> scores = compscoreContext.GetAllScore();
            List<CompetitionScore> specifiedscores = new List<CompetitionScore>();
            List<Criteria> criteria = criteriaContext.GetAllCriteria();


            foreach (CompetitionScore s in scores)
            {
                if (s.CompetitorID == competitorid.Value && s.CompetitionID == competitionid.Value)
                {
                    specifiedscores.Add(s);
                }
            }

            if (specifiedscores.Count == 0)
            {
                foreach (Criteria c in criteria)
                {
                    if (c.CompetitionID == competitionid.Value)
                    {
                        CompetitionScore cs = new CompetitionScore();
                        cs.CriteriaID = c.CriteriaID;
                        cs.CompetitorID = competitorid.Value;
                        cs.CompetitionID = competitionid.Value;
                        cs.Score = 0;



                        specifiedscores.Add(cs);
                        compscoreContext.Add(cs);
                    }
                }
            }


            
            List<CompetitionScoreViewModel> currentScore = new List<CompetitionScoreViewModel>();
            foreach (Criteria c in criteria)
            {
                foreach(CompetitionScore ss in specifiedscores)
                {
                    if (c.CriteriaID == ss.CriteriaID)
                    {
                        CompetitionScoreViewModel csVM = MapToScoreVM(ss);
                        currentScore.Add(csVM);
                    }
                }
            }

            ViewData["Compend"] = competitionContext.GetDetails(competitionid.Value).EndDate;
            

            return View(currentScore);
        }

        //public ActionResult GradeCriterion(int? competitionid, int? competitorid)
        //{

        //}






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

            foreach (Competitor c in competitors)
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
        public CompetitionScoreViewModel MapToScoreVM(CompetitionScore score)
        {
            string criterianame = "";
            int weightage = 0;

            List<Criteria> criList = criteriaContext.GetAllCriteria();
            foreach (Criteria criteria in criList)
            {
                if (criteria.CriteriaID == score.CriteriaID)
                {


                    criterianame = criteria.CriteriaName;
                    weightage = criteria.Weightage;
                    //Exit the foreach loop once the name is found
                    break;
                }
            }


            CompetitionScoreViewModel scoreVM = new CompetitionScoreViewModel
            {
                CriteriaID = score.CriteriaID,
                CompetitorID = score.CompetitorID,
                CompetitionID = score.CompetitionID,
                CriteriaName = criterianame,
                Weightage = weightage,
                Score = score.Score
            };
            return scoreVM;
        }
}
}
