using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBay.Areas.Identity.Data;
using eBay.Models;
using eBay.Models.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eBay.Data
{
    public class eBayContext : IdentityDbContext<eBayUser>
    {
        public eBayContext(DbContextOptions<eBayContext> options)
            : base(options)
        {
        }

        //public DbSet<eBayUser> eBayUsers { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Prodavac> Prodavaci { get; set; }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Proizvod>().ToTable("Proizvod");
            builder.Entity<Kategorija>().ToTable("Kategorija");
        }
    }
}
