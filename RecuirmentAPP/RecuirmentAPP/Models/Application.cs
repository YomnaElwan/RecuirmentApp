using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class Application
    {
        public int Id { get; set; }
        public DateTime ApplyDate { get; set; } = DateTime.UtcNow.AddHours(2);
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
