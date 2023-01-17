using BankerBuddy.Core.FileWriter;
using BankerBuddy.Core.User;

namespace BankerBuddy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            ConfigureDependencyInjection(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureDependencyInjection(IServiceCollection services) 
        {
            services.AddScoped<IUserResolver, BasicUserResolver>();
            services.AddScoped<IFileWriter, FileHandler>();
            services.AddScoped<FilePathResolver>();
        }
    }
}