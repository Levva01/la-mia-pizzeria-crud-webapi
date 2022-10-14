﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace la_mia_pizzeria_crud_mvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221007125818_CategoryAdd")]
    partial class CategoryAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pizze");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
                            Foto = "img/pizza.jpg",
                            Nome = "Margherita",
                            Prezzo = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
                            Foto = "img/pizza.jpg",
                            Nome = "Margherita",
                            Prezzo = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
                            Foto = "img/pizza.jpg",
                            Nome = "Margherita",
                            Prezzo = 5.0
                        },
                        new
                        {
                            Id = 4,
                            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
                            Foto = "img/pizza.jpg",
                            Nome = "Margherita",
                            Prezzo = 5.0
                        },
                        new
                        {
                            Id = 5,
                            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
                            Foto = "img/pizza.jpg",
                            Nome = "Margherita",
                            Prezzo = 5.0
                        });
                });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Pizza", b =>
                {
                    b.HasOne("la_mia_pizzeria_crud_mvc.Models.Category", "Category")
                        .WithMany("Pizze")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Category", b =>
                {
                    b.Navigation("Pizze");
                });
#pragma warning restore 612, 618
        }
    }
}
