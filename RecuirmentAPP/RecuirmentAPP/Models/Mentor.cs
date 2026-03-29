namespace RecuirmentAPP.Models
{
    public class Mentor:User
    {
        public ICollection<Review> Reviews { get; set; }
    }
}
