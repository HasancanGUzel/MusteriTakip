using Microsoft.EntityFrameworkCore;
using MusteriTakip.EfCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore
{
    public class MusteriTakipContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MusteriTakipDb;Integrated Security=true;TrustServerCertificate=true"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Siparis>() // müşteri silersem sipariş de silinsin dedim
               .HasOne(m => m.Musteri)
               .WithMany(s => s.Siparisler)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.ApplyConfiguration(new MusteriConfig());
            modelBuilder.ApplyConfiguration(new UrunConfig());
        }

    }
}
