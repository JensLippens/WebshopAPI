﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopAPI.DbContexts;

#nullable disable

namespace WebShopAPI.Migrations
{
    [DbContext(typeof(WebShopContext))]
    [Migration("20230727175651_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("WebShopAPI.Entities.Klant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gemeente")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefoon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("WebShopAPI.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KlantId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotaalPrijs")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KlantId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebShopAPI.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Aantal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("WebShopAPI.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Inhoud")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categorie = "Makeup",
                            Description = "Gebruikstest gedurende vier weken bij een panel van 26 vrouwen. 85% doeltreffend",
                            Inhoud = 25,
                            Name = "Verhelderende primer",
                            Price = 19.9m
                        },
                        new
                        {
                            Id = 2,
                            Categorie = "Gelaat",
                            Description = "Het ultra-geconcentreerde Aphloia-extract bestrijdt de schadelijke factoren die het huidverouderingsproces versnellen. 90% doeltreffend",
                            Inhoud = 50,
                            Name = "Restructuring care",
                            Price = 18.45m
                        },
                        new
                        {
                            Id = 3,
                            Categorie = "Parfum",
                            Description = "De verfijnde frisheid van Bergamotessence maakt vrij baan voor de subtiel vrouwelijke nasleep van absolue van Damascusroos",
                            Inhoud = 100,
                            Name = "Comme une Evidence - Eau de Parfum",
                            Price = 54.95m
                        });
                });

            modelBuilder.Entity("WebShopAPI.Entities.Order", b =>
                {
                    b.HasOne("WebShopAPI.Entities.Klant", "Klant")
                        .WithMany("Orders")
                        .HasForeignKey("KlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klant");
                });

            modelBuilder.Entity("WebShopAPI.Entities.OrderItem", b =>
                {
                    b.HasOne("WebShopAPI.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShopAPI.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShopAPI.Entities.Klant", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebShopAPI.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("WebShopAPI.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
