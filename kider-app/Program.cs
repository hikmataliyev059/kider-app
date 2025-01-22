using FluentValidation.AspNetCore;
using kider_app.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using kider_app.Models;

namespace kider_app;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews().AddFluentValidation(cfg =>
        {
            cfg.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        });

        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DB_URL"));
        });

        builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
        {
            opt.User.RequireUniqueEmail = true;
            opt.SignIn.RequireConfirmedEmail = false;
            opt.Lockout.MaxFailedAccessAttempts = 10;
            opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            opt.Password.RequiredLength = 4;
        }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
