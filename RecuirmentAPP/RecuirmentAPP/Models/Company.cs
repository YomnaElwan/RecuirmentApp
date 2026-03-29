namespace RecuirmentAPP.Models
{
    public class Company:User
    {
        public ICollection<Job> Jobs { get; set; }
    }
}
