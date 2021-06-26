using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace T03_CompetitionPlatform.Models
{
    public class CompetitionSubmission
    {
        public int CompetitionID { get; set; }
        public int CompetitorID { get; set; }
    }
}
