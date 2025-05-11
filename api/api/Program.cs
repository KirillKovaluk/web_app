using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Services;
using api.Controllers.Filters;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddMvc(options =>
            {
                options.Filters.Add<FilterAction>();
            });

            string? connectionString = builder.Configuration.GetConnectionString("ConnectionString");

            builder.Services.AddDbContext<Context>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Add services .AddTransient .AddSingleton .AddScoped
            builder.Services
                .AddScoped<IErrorService, ErrorService>()
                .AddSingleton<IJWTService, JWTService>()
                .AddScoped<IUserService, UserService>()

                ;

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
