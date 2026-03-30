using RecuirmentAPP.DTOs;
using RecuirmentAPP.Models;
using RecuirmentAPP.Services;
using System.Text.Json;

namespace RecuirmentAPP.Service
{
    public class DataSeedingService : IDataSeedingService
    {
        public void UsersSeed(RecuirmentContext context)
        {
            if (context.Set<User>().Any())  // لو فى بيانات خلاص ما تروحش تحط داتا
                return;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "DataSeeding", "DataSeed.json");
            var json = File.ReadAllText(path);
            var usersDTO = JsonSerializer.Deserialize<List<UserDataSeedingDTO>>(json);
            var users = new List<User>();
            if (usersDTO == null)
                return;
            foreach (var userDTO in usersDTO)
            {
                User user = userDTO.Type switch
                {
                    "Candidate" => new Candidate
                    {
                        UserName = userDTO.UserName,
                        Email = userDTO.Email,
                        Track=userDTO.Track,
                        Password=userDTO.Password,
                        CV = userDTO?.CV??"Null"
                    },
                    "Company"=>new Company
                    {
                        UserName = userDTO.UserName,
                        Email = userDTO.Email,
                        Track=userDTO.Track,
                        Password=userDTO.Password
                    },
                    _ => null
                };
                if(user != null)
                {
                    users.Add(user);
                }
            }
            context.AddRange(users);
            context.SaveChanges();

        }
    }
}
