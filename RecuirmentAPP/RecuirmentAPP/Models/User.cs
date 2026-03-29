
namespace RecuirmentAPP.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Track { get; set; }
        public ICollection<Points> Points { get; set; }
    }
}
