﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP01EF2024.Datos;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    [DbContext(typeof(TPDbContext))]
    [Migration("20240629124106_CreacionTablaShoeSize-CampoActive")]
    partial class CreacionTablaShoeSizeCampoActive
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TP01EF2024.Entidades.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Active = true,
                            BrandName = "Puma"
                        },
                        new
                        {
                            BrandId = 2,
                            Active = true,
                            BrandName = "Boris"
                        },
                        new
                        {
                            BrandId = 3,
                            Active = true,
                            BrandName = "Nike"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Colour", b =>
                {
                    b.Property<int>("ColourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColourId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ColourName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColourId");

                    b.HasIndex("ColourName")
                        .IsUnique();

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            ColourId = 1,
                            Active = true,
                            ColourName = "Negro"
                        },
                        new
                        {
                            ColourId = 2,
                            Active = true,
                            ColourName = "Marron"
                        },
                        new
                        {
                            ColourId = 3,
                            Active = true,
                            ColourName = "Blanco"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Masculino"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Femenino"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Sin Genero"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColourId");

                    b.HasIndex("GenreId");

                    b.HasIndex("SportId");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            ShoeId = 1,
                            Active = true,
                            BrandId = 1,
                            ColourId = 1,
                            Description = "Vans Deportivas",
                            GenreId = 2,
                            Model = "Deportivas",
                            Price = 15m,
                            SportId = 3
                        },
                        new
                        {
                            ShoeId = 2,
                            Active = true,
                            BrandId = 2,
                            ColourId = 1,
                            Description = "Botines Femeninos",
                            GenreId = 1,
                            Model = "Botines",
                            Price = 20m,
                            SportId = 1
                        },
                        new
                        {
                            ShoeId = 3,
                            Active = true,
                            BrandId = 3,
                            ColourId = 1,
                            Description = "Importados",
                            GenreId = 3,
                            Model = "1982",
                            Price = 35m,
                            SportId = 2
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.ShoeSize", b =>
                {
                    b.Property<int>("ShoeSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeSizeId"));

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<int>("ShoeId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ShoeSizeId");

                    b.HasIndex("SizeId");

                    b.HasIndex("ShoeId", "SizeId")
                        .IsUnique();

                    b.ToTable("ShoesSizes", (string)null);
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"));

                    b.Property<decimal>("SizeNumber")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal (3, 1)");

                    b.HasKey("SizeId");

                    b.HasIndex("SizeNumber")
                        .IsUnique();

                    b.ToTable("Sizes", (string)null);

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            SizeNumber = 28m
                        },
                        new
                        {
                            SizeId = 2,
                            SizeNumber = 28.5m
                        },
                        new
                        {
                            SizeId = 3,
                            SizeNumber = 29.0m
                        },
                        new
                        {
                            SizeId = 4,
                            SizeNumber = 29.5m
                        },
                        new
                        {
                            SizeId = 5,
                            SizeNumber = 30.0m
                        },
                        new
                        {
                            SizeId = 6,
                            SizeNumber = 30.5m
                        },
                        new
                        {
                            SizeId = 7,
                            SizeNumber = 31.0m
                        },
                        new
                        {
                            SizeId = 8,
                            SizeNumber = 31.5m
                        },
                        new
                        {
                            SizeId = 9,
                            SizeNumber = 32.0m
                        },
                        new
                        {
                            SizeId = 10,
                            SizeNumber = 32.5m
                        },
                        new
                        {
                            SizeId = 11,
                            SizeNumber = 33.0m
                        },
                        new
                        {
                            SizeId = 12,
                            SizeNumber = 33.5m
                        },
                        new
                        {
                            SizeId = 13,
                            SizeNumber = 34.0m
                        },
                        new
                        {
                            SizeId = 14,
                            SizeNumber = 34.5m
                        },
                        new
                        {
                            SizeId = 15,
                            SizeNumber = 35.0m
                        },
                        new
                        {
                            SizeId = 16,
                            SizeNumber = 35.5m
                        },
                        new
                        {
                            SizeId = 17,
                            SizeNumber = 36.0m
                        },
                        new
                        {
                            SizeId = 18,
                            SizeNumber = 36.5m
                        },
                        new
                        {
                            SizeId = 19,
                            SizeNumber = 37.0m
                        },
                        new
                        {
                            SizeId = 20,
                            SizeNumber = 37.5m
                        },
                        new
                        {
                            SizeId = 21,
                            SizeNumber = 38.0m
                        },
                        new
                        {
                            SizeId = 22,
                            SizeNumber = 38.5m
                        },
                        new
                        {
                            SizeId = 23,
                            SizeNumber = 39.0m
                        },
                        new
                        {
                            SizeId = 24,
                            SizeNumber = 39.5m
                        },
                        new
                        {
                            SizeId = 25,
                            SizeNumber = 40.0m
                        },
                        new
                        {
                            SizeId = 26,
                            SizeNumber = 40.5m
                        },
                        new
                        {
                            SizeId = 27,
                            SizeNumber = 41.0m
                        },
                        new
                        {
                            SizeId = 28,
                            SizeNumber = 41.5m
                        },
                        new
                        {
                            SizeId = 29,
                            SizeNumber = 42.0m
                        },
                        new
                        {
                            SizeId = 30,
                            SizeNumber = 42.5m
                        },
                        new
                        {
                            SizeId = 31,
                            SizeNumber = 43.0m
                        },
                        new
                        {
                            SizeId = 32,
                            SizeNumber = 43.5m
                        },
                        new
                        {
                            SizeId = 33,
                            SizeNumber = 44.0m
                        },
                        new
                        {
                            SizeId = 34,
                            SizeNumber = 44.5m
                        },
                        new
                        {
                            SizeId = 35,
                            SizeNumber = 45.0m
                        },
                        new
                        {
                            SizeId = 36,
                            SizeNumber = 45.5m
                        },
                        new
                        {
                            SizeId = 37,
                            SizeNumber = 46.0m
                        },
                        new
                        {
                            SizeId = 38,
                            SizeNumber = 46.5m
                        },
                        new
                        {
                            SizeId = 39,
                            SizeNumber = 47.0m
                        },
                        new
                        {
                            SizeId = 40,
                            SizeNumber = 47.5m
                        },
                        new
                        {
                            SizeId = 41,
                            SizeNumber = 48.0m
                        },
                        new
                        {
                            SizeId = 42,
                            SizeNumber = 48.5m
                        },
                        new
                        {
                            SizeId = 43,
                            SizeNumber = 49.0m
                        },
                        new
                        {
                            SizeId = 44,
                            SizeNumber = 49.5m
                        },
                        new
                        {
                            SizeId = 45,
                            SizeNumber = 50.0m
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Sport", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SportId");

                    b.HasIndex("SportName")
                        .IsUnique();

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = 1,
                            Active = true,
                            SportName = "Futbol"
                        },
                        new
                        {
                            SportId = 2,
                            Active = true,
                            SportName = "Atletismo"
                        },
                        new
                        {
                            SportId = 3,
                            Active = true,
                            SportName = "Tenis"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.HasOne("TP01EF2024.Entidades.Brand", "Brand")
                        .WithMany("Shoes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Colour", "Colour")
                        .WithMany("Shoes")
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Genre", "Genre")
                        .WithMany("Shoes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Sport", "Sport")
                        .WithMany("Shoes")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Colour");

                    b.Navigation("Genre");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.ShoeSize", b =>
                {
                    b.HasOne("TP01EF2024.Entidades.Shoe", "Shoe")
                        .WithMany("ShoesSizes")
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Size", "Size")
                        .WithMany("ShoesSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shoe");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Brand", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Colour", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Genre", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.Navigation("ShoesSizes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Size", b =>
                {
                    b.Navigation("ShoesSizes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Sport", b =>
                {
                    b.Navigation("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
