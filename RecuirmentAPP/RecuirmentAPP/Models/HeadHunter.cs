namespace RecuirmentAPP.Models
{
    public class HeadHunter:User
    {
       public ICollection<Match> Matches { get; set; }
    }
}
