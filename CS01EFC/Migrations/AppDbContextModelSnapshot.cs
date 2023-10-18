﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CS01EFC.Data;

#nullable disable

namespace CS01EFC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CS01EFC.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            FirstName = "Keanu",
                            Gender = 1,
                            LastName = "Reeves"
                        },
                        new
                        {
                            ArtistId = 2,
                            FirstName = "Timothée",
                            Gender = 1,
                            LastName = "Chalamet"
                        },
                        new
                        {
                            ArtistId = 3,
                            FirstName = "",
                            Gender = 2,
                            LastName = "Zendaya"
                        });
                });

            modelBuilder.Entity("CS01EFC.Models.ArtistMovie", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ArtistMovie", (string)null);
                });

            modelBuilder.Entity("_200923PRG.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Horror"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Životopis"
                        });
                });

            modelBuilder.Entity("_200923PRG.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Duration = 180,
                            GenreId = 1,
                            Name = "Dune"
                        },
                        new
                        {
                            MovieId = 2,
                            Duration = 150,
                            GenreId = 3,
                            Name = "Oppenheimer"
                        });
                });

            modelBuilder.Entity("_200923PRG.Models.ArtistMovie", b =>
                {
                    b.HasOne("_200923PRG.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("_200923PRG.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("_200923PRG.Models.Movie", b =>
                {
                    b.HasOne("_200923PRG.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("_200923PRG.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}