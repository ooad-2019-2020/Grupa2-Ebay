using System;
using eBay.Areas.Identity.Data;
using eBay.Data;
using eBay.Models.Korisnici;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(eBay.Areas.Identity.IdentityHostingStartup))]
namespace eBay.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<eBayContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("eBayContextConnection")));

            //    services.AddDefaultIdentity<eBayUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddRoles<Prodavac>()
            //        .AddRoles<Kupac>()
            //        .AddEntityFrameworkStores<eBayContext>();
            //});
        }
    }
}