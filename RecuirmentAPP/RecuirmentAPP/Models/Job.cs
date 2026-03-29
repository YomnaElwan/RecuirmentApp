using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }  
        public Company Company { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
