using System.ComponentModel.DataAnnotations.Schema;

namespace RecuirmentAPP.Models
{
    public class AuditLog
    {
        public Guid Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string ActionName { get; set; }
        public string EntityName { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow.AddHours(2);

        

    }
}
