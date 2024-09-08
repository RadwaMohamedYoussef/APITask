﻿// <auto-generated />
using System;
using APITask.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240908035849_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APITask.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Line 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Line 2"
                        });
                });

            modelBuilder.Entity("APITask.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int?>("TransitionalStationId")
                        .HasColumnType("int");

                    b.Property<bool>("isTransitional")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.HasIndex("TransitionalStationId");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LineId = 1,
                            Name = "Helwan",
                            Position = 1,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 2,
                            LineId = 1,
                            Name = "Ain Helwan",
                            Position = 2,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 3,
                            LineId = 1,
                            Name = "Helwan University",
                            Position = 3,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 4,
                            LineId = 1,
                            Name = "Wadi Hof",
                            Position = 4,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 5,
                            LineId = 1,
                            Name = "Hadayek Helwan",
                            Position = 5,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 6,
                            LineId = 1,
                            Name = "El-Maasara",
                            Position = 6,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 7,
                            LineId = 1,
                            Name = "Tora El-Balad",
                            Position = 7,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 8,
                            LineId = 1,
                            Name = "Kozzika",
                            Position = 8,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 9,
                            LineId = 1,
                            Name = "Tora El-Asmant",
                            Position = 9,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 10,
                            LineId = 1,
                            Name = "Sakanat El-Maadi",
                            Position = 10,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 11,
                            LineId = 1,
                            Name = "Maadi",
                            Position = 11,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 12,
                            LineId = 1,
                            Name = "Hadayek El-Maadi",
                            Position = 12,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 13,
                            LineId = 1,
                            Name = "Dar El-Salam",
                            Position = 13,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 14,
                            LineId = 1,
                            Name = "El-Zahraa",
                            Position = 14,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 15,
                            LineId = 1,
                            Name = "Mar Girgis",
                            Position = 15,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 16,
                            LineId = 1,
                            Name = "El-Malek El-Saleh",
                            Position = 16,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 17,
                            LineId = 1,
                            Name = "Al-Sayeda Zeinab",
                            Position = 17,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 18,
                            LineId = 1,
                            Name = "Saad Zaghloul",
                            Position = 18,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 19,
                            LineId = 1,
                            Name = "Sadat",
                            Position = 19,
                            TransitionalStationId = 45,
                            isTransitional = true
                        },
                        new
                        {
                            Id = 20,
                            LineId = 1,
                            Name = "Nasser",
                            Position = 20,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 21,
                            LineId = 1,
                            Name = "Orabi",
                            Position = 21,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 22,
                            LineId = 1,
                            Name = "Al-Shohadaa",
                            Position = 22,
                            TransitionalStationId = 43,
                            isTransitional = true
                        },
                        new
                        {
                            Id = 23,
                            LineId = 1,
                            Name = "Ghamra",
                            Position = 23,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 24,
                            LineId = 1,
                            Name = "El-Demerdash",
                            Position = 24,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 25,
                            LineId = 1,
                            Name = "Manshiet El-Sadr",
                            Position = 25,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 26,
                            LineId = 1,
                            Name = "Kobri El-Qobba",
                            Position = 26,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 27,
                            LineId = 1,
                            Name = "Hammamat El-Qobba",
                            Position = 27,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 28,
                            LineId = 1,
                            Name = "Saray El-Qobba",
                            Position = 28,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 29,
                            LineId = 1,
                            Name = "Hadayeq El-Zaitoun",
                            Position = 29,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 30,
                            LineId = 1,
                            Name = "Helmeyet El-Zaitoun",
                            Position = 30,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 31,
                            LineId = 1,
                            Name = "El-Matareyya",
                            Position = 31,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 32,
                            LineId = 1,
                            Name = "Ain Shams",
                            Position = 32,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 33,
                            LineId = 1,
                            Name = "Ezbet El-Nakhl",
                            Position = 33,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 34,
                            LineId = 1,
                            Name = "El-Marg",
                            Position = 34,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 35,
                            LineId = 1,
                            Name = "El-Marg El-Gedida",
                            Position = 35,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 36,
                            LineId = 2,
                            Name = "Shubra El-Kheima",
                            Position = 1,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 37,
                            LineId = 2,
                            Name = "Kolleyet El-Zeraa",
                            Position = 2,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 38,
                            LineId = 2,
                            Name = "El-Mazalat",
                            Position = 3,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 39,
                            LineId = 2,
                            Name = "El-Khalafawi",
                            Position = 4,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 40,
                            LineId = 2,
                            Name = "St. Teresa",
                            Position = 5,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 41,
                            LineId = 2,
                            Name = "Rod El-Farag",
                            Position = 6,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 42,
                            LineId = 2,
                            Name = "Masarra",
                            Position = 7,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 43,
                            LineId = 2,
                            Name = "Al-Shohadaa",
                            Position = 8,
                            TransitionalStationId = 22,
                            isTransitional = true
                        },
                        new
                        {
                            Id = 44,
                            LineId = 2,
                            Name = "Attaba",
                            Position = 9,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 45,
                            LineId = 2,
                            Name = "Sadat",
                            Position = 10,
                            TransitionalStationId = 19,
                            isTransitional = true
                        },
                        new
                        {
                            Id = 46,
                            LineId = 2,
                            Name = "Opera",
                            Position = 11,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 47,
                            LineId = 2,
                            Name = "Dokki",
                            Position = 12,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 48,
                            LineId = 2,
                            Name = "Cairo University",
                            Position = 13,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 49,
                            LineId = 2,
                            Name = "Faisal",
                            Position = 14,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 50,
                            LineId = 2,
                            Name = "Giza",
                            Position = 15,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 51,
                            LineId = 2,
                            Name = "Omm El-Masryeen",
                            Position = 16,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 52,
                            LineId = 2,
                            Name = "Sakiat Mekki",
                            Position = 17,
                            isTransitional = false
                        },
                        new
                        {
                            Id = 53,
                            LineId = 2,
                            Name = "El-Mounib",
                            Position = 18,
                            isTransitional = false
                        });
                });

            modelBuilder.Entity("APITask.Models.Station", b =>
                {
                    b.HasOne("APITask.Models.Line", "Line")
                        .WithMany("Stations")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APITask.Models.Station", "TransitionalStation")
                        .WithMany()
                        .HasForeignKey("TransitionalStationId");

                    b.Navigation("Line");

                    b.Navigation("TransitionalStation");
                });

            modelBuilder.Entity("APITask.Models.Line", b =>
                {
                    b.Navigation("Stations");
                });
#pragma warning restore 612, 618
        }
    }
}
