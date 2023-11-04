﻿// <auto-generated />
using System;
using Jungle_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    [DbContext(typeof(JungleDbContext))]
    partial class JungleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jungle_Models.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Jungle_Models.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("date");

                    b.Property<int>("LimiteCredit")
                        .HasColumnType("int");

                    b.Property<string>("NoCarteCredit")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("NoTelephone1")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NoTelephone2")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Jungle_Models.Models.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Guides");
                });

            modelBuilder.Entity("Jungle_Models.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReservationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDepart")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("NombrePlaces")
                        .HasColumnType("int");

                    b.Property<int>("PourcentageRabais")
                        .HasColumnType("int");

                    b.Property<double>("PrixFinal")
                        .HasColumnType("float");

                    b.Property<bool>("StatusConfirme")
                        .HasColumnType("bit");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Jungle_Models.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GuideId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<int>("NombrePlaces")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("TravelRecommendationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("GuideId");

                    b.HasIndex("TravelRecommendationId")
                        .IsUnique();

                    b.ToTable("Travels");
                });

            modelBuilder.Entity("Jungle_Models.Models.TravelRecommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DangerLevel")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("TravelRecommendations");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.HasOne("Jungle_Models.Models.Country", "Country")
                        .WithMany("Destinations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Jungle_Models.Models.Reservation", b =>
                {
                    b.HasOne("Jungle_Models.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jungle_Models.Models.Travel", "Travel")
                        .WithMany("Reservations")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Travel");
                });

            modelBuilder.Entity("Jungle_Models.Models.Travel", b =>
                {
                    b.HasOne("Jungle_Models.Models.Destination", null)
                        .WithMany("Travels")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jungle_Models.Models.Guide", "Guide")
                        .WithMany("Travels")
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jungle_Models.Models.TravelRecommendation", "TravelRecommendation")
                        .WithOne("Travel")
                        .HasForeignKey("Jungle_Models.Models.Travel", "TravelRecommendationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guide");

                    b.Navigation("TravelRecommendation");
                });

            modelBuilder.Entity("Jungle_Models.Models.Country", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("Jungle_Models.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.Navigation("Travels");
                });

            modelBuilder.Entity("Jungle_Models.Models.Guide", b =>
                {
                    b.Navigation("Travels");
                });

            modelBuilder.Entity("Jungle_Models.Models.Travel", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Jungle_Models.Models.TravelRecommendation", b =>
                {
                    b.Navigation("Travel")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
