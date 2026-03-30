namespace RecuirmentAPP.DTOs
{
    public class UserDataSeedingDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Track { get; set; }
        public string Type { get; set; } // Candidate , Company, HeadHunter
        public string? CV { get; set; }
    }
}
