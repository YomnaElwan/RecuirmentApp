
using Microsoft.EntityFrameworkCore;
using RecuirmentAPP.Models;
using RecuirmentAPP.Service;
using RecuirmentAPP.Services;

namespace RecuirmentAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<RecuirmentContext>(options =>
    options.UseSqlServer("Data Source=AHMEDELWAN\\SQLEXPRESS;Initial Catalog=RecuirmentSystemDB;Integrated Security=True;TrustServerCertificate=True"));
            builder.Services.AddScoped<IDataSeedingService, DataSeedingService>();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<RecuirmentContext>();
                var seedingService = services.GetRequiredService<IDataSeedingService>();
                seedingService.UsersSeed(context);

            }
            


                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.MapOpenApi();
                }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
