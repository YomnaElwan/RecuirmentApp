using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class Match
    {
        public int Id { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        public Job Job { get; set; }
        [ForeignKey("HeadHunter")]
        public int HeadHunterId { get; set; }
        public HeadHunter HeadHunter { get; set; }

    }
}
