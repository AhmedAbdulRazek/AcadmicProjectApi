
using Day02Task.BL.Managers;
using Day02Task.DAL.Context;
using Day02Task.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace Day02Task.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string myTxt = "txt";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddScoped<IInstructorManager, InstructorManager>();
            builder.Services.AddScoped<IInstructorRep, InstructorRep>();

            builder.Services.AddDbContext<CompanyContext>(opt =>
            opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));

            //cors policy
            //builder.Services.AddCors();


            builder.Services.AddCors(o =>
            {
                o.AddPolicy(myTxt, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });



            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(myTxt);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}