using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore.Config
{
    public class UrunConfig : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(u => u.Id);//primary key burası olucak
            builder.Property(u => u.Id).ValueGeneratedOnAdd();// id nin 1 den başlayıp 1er 1 er artmasını sağlar

            builder.Property(u => u.Adi)
                .IsRequired()//Zorunlu alan dedik
                .HasMaxLength(50);// buda uzunluğu

            builder.Property(u => u.Miktar)
                .IsRequired();

            builder.Property(u => u.BarkodNo)
               .IsRequired();

            builder.Property(u => u.Fiyat)
               .IsRequired();

            builder.HasData(
               new Urun
               {
                   Id = 1,
                   Adi = "Telefon",
                   Miktar = 3,
                   BarkodNo = 123457,
                   Fiyat = 05367894561
                  


               },
               new Urun
               {
                   Id = 2,
                   Adi = "Bilgisayar",
                   Miktar = 5,
                   BarkodNo = 123456,
                   Fiyat = 05367894561

               }
               );

        }
    }
}
