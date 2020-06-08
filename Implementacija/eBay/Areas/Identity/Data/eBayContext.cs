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

        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Prodavac> Prodavaci { get; set; }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Korpa> Korpe { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<StavkaRacuna> StavkeRacuna { get; set; }
        public DbSet<StavkaKorpe> StavkeKorpe { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Proizvod>().ToTable("Proizvod");
            builder.Entity<Kategorija>().ToTable("Kategorija");
            builder.Entity<Korpa>().ToTable("Korpa");
            builder.Entity<Racun>().ToTable("Racun");
            builder.Entity<StavkaRacuna>().ToTable("StavkaRacuna");


        }
    }
}
