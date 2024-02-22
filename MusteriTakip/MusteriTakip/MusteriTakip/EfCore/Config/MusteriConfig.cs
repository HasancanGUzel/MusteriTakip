using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore.Config
{
    public class MusteriConfig : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(u => u.Id);//primary key burası olucak
            builder.Property(u => u.Id).ValueGeneratedOnAdd();// id nin 1 den başlayıp 1er 1 er artmasını sağlar

            builder.Property(u => u.Ad)
                .IsRequired()//Zorunlu alan dedik
                .HasMaxLength(50);// buda uzunluğu

            builder.Property(u => u.Soyad)
               .IsRequired()//Zorunlu alan dedik
               .HasMaxLength(50);// buda uzunluğu

            builder.Property(u => u.Adres)
                .IsRequired()//Zorunlu alan dedik
                .HasMaxLength(50);// buda uzunluğu

            builder.Property(u => u.Telefon)
                .IsRequired()//Zorunlu alan dedik
                .HasMaxLength(11);// buda uzunluğu

            builder.Property(u => u.TCKN)
               .IsRequired()//Zorunlu alan dedik
               .HasMaxLength(11);// buda uzunluğu

            builder.HasData(
                new Musteri
                {
                    Id = 1,
                    Ad = "Ahmet",
                    Soyad = "Mehmet",
                    Adres = "adress",
                    Telefon = 05367894561,
                    TCKN = 12345678911
                  

                },
                new Musteri
                {
                    Id = 2,
                    Ad = "ayşe",
                    Soyad = "fatma",
                    Adres = "adress",
                    Telefon = 05367894568,
                    TCKN = 12345678912

                }
                );




        }
    }
}
