﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusteriTakip.EfCore;

#nullable disable

namespace MusteriTakip.Migrations
{
    [DbContext(typeof(MusteriTakipContext))]
    [Migration("20240221073153_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusteriTakip.EfCore.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("TCKN")
                        .HasMaxLength(11)
                        .HasColumnType("float");

                    b.Property<double>("Telefon")
                        .HasMaxLength(11)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Ahmet",
                            Adres = "adress",
                            Soyad = "Mehmet",
                            TCKN = 12345678911.0,
                            Telefon = 5367894561.0
                        },
                        new
                        {
                            Id = 2,
                            Ad = "ayşe",
                            Adres = "adress",
                            Soyad = "fatma",
                            TCKN = 12345678912.0,
                            Telefon = 5367894568.0
                        });
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MusteriId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisDetaylar");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BarkodNo")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Telefon",
                            BarkodNo = 123457,
                            Fiyat = 5367894561m,
                            Miktar = 3
                        },
                        new
                        {
                            Id = 2,
                            Adi = "Bilgisayar",
                            BarkodNo = 123456,
                            Fiyat = 5367894561m,
                            Miktar = 5
                        });
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Siparis", b =>
                {
                    b.HasOne("MusteriTakip.EfCore.Musteri", "Musteri")
                        .WithMany("Siparisler")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.SiparisDetay", b =>
                {
                    b.HasOne("MusteriTakip.EfCore.Siparis", "Siparis")
                        .WithMany("SiparisDetay")
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusteriTakip.EfCore.Urun", "Urun")
                        .WithMany("SiparisDetaylar")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Musteri", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Siparis", b =>
                {
                    b.Navigation("SiparisDetay");
                });

            modelBuilder.Entity("MusteriTakip.EfCore.Urun", b =>
                {
                    b.Navigation("SiparisDetaylar");
                });
#pragma warning restore 612, 618
        }
    }
}
