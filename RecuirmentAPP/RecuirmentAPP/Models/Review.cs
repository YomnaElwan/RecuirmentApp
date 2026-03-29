using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }  // Review content
        public int Rating { get; set; }  // Rating out of 5
        [ForeignKey("Mentor")]
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }    
        public Candidate Candidate { get; set; }



    }
}
