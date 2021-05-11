using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp_FizzBuzz.Data;

[assembly: HostingStartup(typeof(WebApp_FizzBuzz.Areas.Identity.IdentityHostingStartup))]
namespace WebApp_FizzBuzz.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Accounts>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountsConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Accounts>();
            });
        }
    }
}