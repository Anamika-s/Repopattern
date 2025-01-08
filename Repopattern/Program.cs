using Microsoft.EntityFrameworkCore;
using Repopattern.Context;
using Repopattern.IRepo;
using Repopattern.Repo;

namespace Repopattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddScoped<BatchRepo>();
            //builder.Services.AddScoped<BatchRepo1>();
            builder.Services.AddScoped<IBatchRepo, BatchRepo>();
            builder.Services.AddScoped<IBatchRepo, BatchRepo1>();
            builder.Services.AddDbContext<BatchDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
