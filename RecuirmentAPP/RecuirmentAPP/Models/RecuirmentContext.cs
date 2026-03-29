using Microsoft.EntityFrameworkCore;

namespace RecuirmentAPP.Models
{
    public class RecuirmentContext:DbContext
    {
        public DbSet<Application> Applications { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<HeadHunter> HeadHunters { get; set; }
        public DbSet<Company> Companies { get;set; }
        public DbSet<Mentor> Mentors { get; set; }  
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public RecuirmentContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AHMEDELWAN\\SQLEXPRESS;Initial Catalog=RecuirmentSystemDB;Integrated Security=True;TrustServerCertificate=True");

        }
    }
}
