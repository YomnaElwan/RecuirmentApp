using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow.AddHours(2);
        [ForeignKey("Company")]
        public int CompanyId { get; set; }  
        public Company Company { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
