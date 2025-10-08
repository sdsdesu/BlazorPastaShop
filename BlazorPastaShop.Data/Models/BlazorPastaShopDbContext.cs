using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPastaShop.Data.Models
{
    public class BlazorPastaShopDbContext : DbContext
    {
        public BlazorPastaShopDbContext(DbContextOptions<BlazorPastaShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Klant configuratie
            modelBuilder.Entity<Klant>(entity =>
            {
                entity.HasKey(k => k.KlantId);
                entity.Property(k => k.Naam).IsRequired();
                entity.Property(k => k.Voornaam).IsRequired();
                entity.Property(k => k.Email).IsRequired();
                entity.Property(k => k.Telefoon).IsRequired();
            });

            // Bestelling configuratie
            modelBuilder.Entity<Bestelling>(entity =>
            {
                entity.HasKey(b => b.Id);
                /*
                entity.HasOne(b => b.Klant)
                      .WithMany(k => k.Bestellingen)
                      .HasForeignKey(b => b.KlantId);
                */
                
            });

           
        }
    }
}
