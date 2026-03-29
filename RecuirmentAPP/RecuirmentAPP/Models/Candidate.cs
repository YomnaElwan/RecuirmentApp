namespace RecuirmentAPP.Models
{
    public class Candidate:User
    {
        public string CV { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Review> Reviews { get; set; }    
        public ICollection<Match> Matches { get; set; }
    }
}
