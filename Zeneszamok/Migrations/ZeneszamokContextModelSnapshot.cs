﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zeneszamok.Models;

#nullable disable

namespace Zeneszamok.Migrations
{
    [DbContext(typeof(ZeneszamokContext))]
    partial class ZeneszamokContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EloadoKiado", b =>
                {
                    b.Property<int>("EloadokId")
                        .HasColumnType("int");

                    b.Property<int>("KiadokId")
                        .HasColumnType("int");

                    b.HasKey("EloadokId", "KiadokId");

                    b.HasIndex("KiadokId");

                    b.ToTable("EloadoKiado");
                });

            modelBuilder.Entity("Zeneszamok.Models.Eloado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Elo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nemzetiseg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Eloadok");
                });

            modelBuilder.Entity("Zeneszamok.Models.Kiado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("AlapitasiEv")
                        .HasColumnType("smallint");

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Kiadok");
                });

            modelBuilder.Entity("Zeneszamok.Models.Zeneszam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EloadoId")
                        .HasColumnType("int");

                    b.Property<double>("Hossz")
                        .HasColumnType("double");

                    b.Property<bool>("Jogdija")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("KiadoId")
                        .HasColumnType("int");

                    b.Property<int>("MegjelenesiEv")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EloadoId");

                    b.HasIndex("KiadoId");

                    b.ToTable("Zeneszamok");
                });

            modelBuilder.Entity("EloadoKiado", b =>
                {
                    b.HasOne("Zeneszamok.Models.Eloado", null)
                        .WithMany()
                        .HasForeignKey("EloadokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zeneszamok.Models.Kiado", null)
                        .WithMany()
                        .HasForeignKey("KiadokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Zeneszamok.Models.Zeneszam", b =>
                {
                    b.HasOne("Zeneszamok.Models.Eloado", "Eloado")
                        .WithMany("Zeneszamok")
                        .HasForeignKey("EloadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zeneszamok.Models.Kiado", "Kiado")
                        .WithMany("Zeneszamok")
                        .HasForeignKey("KiadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eloado");

                    b.Navigation("Kiado");
                });

            modelBuilder.Entity("Zeneszamok.Models.Eloado", b =>
                {
                    b.Navigation("Zeneszamok");
                });

            modelBuilder.Entity("Zeneszamok.Models.Kiado", b =>
                {
                    b.Navigation("Zeneszamok");
                });
#pragma warning restore 612, 618
        }
    }
}
