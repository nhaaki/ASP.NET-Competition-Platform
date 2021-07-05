using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace T03_CompetitionPlatform.Models
{
    public class CompetitionSubmission
    {
        [Required]
        public int CompetitionID { get; set; }
        
        [Required]
        public int CompetitorID { get; set; }

        [StringLength(255)]
        public string FileSubmitted { get; set; }

        [DisplayFormat(DataFormatString ="{yyyy-MM-dd }")]
        public DateTime DateTimeFileUpload { get; set; } 

        [StringLength(255)]
        public string Appeal { get; set; }

        [Required]
        public int VoteCount { get; set; }

        //[Range(1)]
        public int Ranking { get; set; }
    }
}
