using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Services;
using api.Controllers.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthentication(x =>
            {
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(config =>
                {
                    config.RequireHttpsMetadata = false;
                    config.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Authorization:Key"]))
                    };
                });


            // Add services to the container
            builder.Services.AddMvc(options =>
            {
                options.Filters.Add<FilterAction>();
            });

            string? connectionString = builder.Configuration.GetConnectionString("ConnectionString");

            builder.Services.AddDbContext<Context>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Add services .AddTransient .AddSingleton .AddScoped
            builder.Services
                .AddTransient<IHttpContextAccessor, HttpContextAccessor>()
                .AddHostedService<TimedHostedService>()
                .AddScoped<ILotBackgroundService, LotBackgroundService>()
                .AddScoped<IErrorService, ErrorService>()
                .AddSingleton<IJWTService, JWTService>()
                .AddScoped<ILotService, LotService>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IUserContext, UserContext>()
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

            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers["Cache-Control"] = "public,max-age=" + 31557600;
                }
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
