using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using RetroGame_Cafe.BLL.Helpper;
using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Services;
using RetroGame_Cafe.DAL;
using RetroGame_Cafe.DAL.Interface;
using RetroGame_Cafe.DAL.Repositories;

namespace RetroGame_Cafe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IVideoGameRepository, VideoGameRepository>();
            builder.Services.AddScoped<IMemberRepository, MemberRepository>();

            builder.Services.AddScoped<IProductsService, ProductService>();
            builder.Services.AddScoped<IVideoGameService, VideoGameService>();
            builder.Services.AddScoped<IMembersService, MemberService>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IHasherHelper, HasherHelper>();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                            .AddCookie(option =>
                            {
                                option.LoginPath = "/Auth/Login";
                                option.AccessDeniedPath = "/Auth/Login";
                                option.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
