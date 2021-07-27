using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T03_CompetitionPlatform.Models
{
    public class CompetitionSubViewModel
    {

        public List<Competition> compList { get; set; }
        public List<CompetitionSubmission> subList { get; set; }

        public CompetitionSubViewModel()
        {
            compList = new List<Competition>();
            subList = new List<CompetitionSubmission>();
        }
    }
}
